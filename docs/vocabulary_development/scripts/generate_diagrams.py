from dotenv import load_dotenv
import os
import glob
import networkx as nx
from networkx.drawing.nx_pydot import write_dot
import pydot
from networkx.drawing.nx_pydot import to_pydot
from networkx.drawing.nx_pydot import pydot_layout
import itertools


#####################################################################
# 
#   Author: Espen Solbu
#   Changelog: 
#   * Nov 19 - 2021: First version
#
#--------------------------------------------------------------------
# Installation
# Must have python and pip installed, then
# 'pip install -r requirements.txt'
#
# Usage
# Run script with
# python generate_diagrams.py
# The script will use default folders for definitions and outputs
#
# Optionally
# Set environment variables for:
# * DEFINITION_FOLDER - location of md files
# * DOTFILE_FOLDER - location of generated dot files
# * PNGFILE_FOLDER - location of generated png files
#
#
#####################################################################

load_dotenv()

folder = "../definitions"
dotfolder = "../dotfiles"
pngFolder = "../diagrams/generated"

if os.getenv("DEFINITION_FOLDER")!=None:
    folder = os.getenv("DEFINITION_FOLDER")

if os.getenv("DOTFILE_FOLDER")!=None:
    dotfolder = os.getenv("DOTFILE_FOLDER")

if os.getenv("PNGFILE_FOLDER")!=None:
    pngFolder = os.getenv("PNGFILE_FOLDER")

topLevelNode = "DWISNoun"

print(folder)

def getClassName(line):
    """
    Added to allow the use of both Alt text for links, and unlinked class references
    """
    if line.find("[")>-1:
        c = line[line.find("[")+1:line.find("]")]
    else:
        c = line[line.find(":")+1:].strip()

    if c!="":
        return c
    else:
        return None


def parseContents(contents):
    nodes = []
    relationships = []
    ignoredRels = []
    noun = None
    verb = None
    lines = contents.split("\n")
    for line in lines:
        if line.startswith("##") and line.endswith("<!-- NOUN -->"):
            # found start of a noun
            noun = line.replace("##","").replace("<!-- NOUN -->","").strip()
            verb = None
            parentClass = None
            subjectClass = None
            objectClass = None

            if noun != None and noun not in nodes:
                nodes.append(noun)
        elif line.startswith("- Parent class:") and noun!=None:
            # found the parent relationship
            #parentClass = line[line.find("[")+1:line.find("]")]
            parentClass = getClassName(line)
            if parentClass!=None and parentClass not in nodes:
                nodes.append(parentClass)

            # if parentClass!=None:
            #     print("ParentClass: '{}'".format(parentClass))
            
            if noun!=None and parentClass!=None:
                r = [noun,parentClass,{'label':"SUBCLASS_OF"}]
                relationships.append(r)
            
        elif line.startswith("##") and line.endswith("<!-- VERB -->"):
            # Found start of a verb
            noun = None
            parentClass = None

            subjectClass = None
            objectClass = None

            verb = line[line.find(" ")+1:line.find(" <")]
        elif line.startswith("- Subject class:") and verb!=None:
            #subjectClass = line[line.find("[")+1:line.find("]")]
            subjectClass = getClassName(line)
        elif line.startswith("- Object class:") and verb!=None:
            #objectClass = line[line.find("[")+1:line.find("]")]
            objectClass = getClassName(line)


        
        
        if verb!=None and subjectClass!=None and objectClass!=None:
            r = [subjectClass,objectClass,{'label':verb}]
            if objectClass != None and objectClass not in nodes:
                nodes.append(objectClass)
            if subjectClass != None and subjectClass not in nodes:
                nodes.append(subjectClass)
            if r not in relationships:
                #print("{} {} {}".format(subjectClass,verb,objectClass))
                if subjectClass==topLevelNode and objectClass==topLevelNode: 
                    # These top level relationships clutter the diagrams, we will ignore these
                    ignoredRels.append(r)
                else:
                    relationships.append(r)
            
            
            
            

            
        #print(line)
        
    return nodes,relationships,ignoredRels
            
# construct empty graph
G = nx.MultiDiGraph()
graphs = {}
fileNodes = {}

allNodes = []
allRels = []
allIgnoredRels = []

# Read all the md files
filenames = glob.glob(folder+"/*.md")
for filename in filenames:
    with open(filename,"r") as fp:
        print("Reading '{}'".format(filename))
        fileContent = fp.read()
        nodes, relationships,ignoredRels = parseContents(fileContent)

        #print(relationships)
        fileNodes[filename] = nodes
        allNodes.extend(nodes)
        allRels.extend(relationships)
        allIgnoredRels.extend(ignoredRels)

print("Populate Graph")

# try to make unique to prevent duplication of nodes and edges
allNodes = list(set(allNodes))
allNodes.sort()

allIgnoredRels = list(k for k,_ in itertools.groupby(allIgnoredRels))

G.add_nodes_from(allNodes)
G.add_edges_from(allRels)

print("Generate files")


generatedReadmeContents = []    # used to hold contents of README.md
generatedReadmeContents.append("# Generated Diagrams")
generatedReadmeContents.append("")

for filename in filenames:
    # Construct diagrams that "include nodes from each md file"
    nodes = fileNodes[filename]
    graphs[filename] = G.subgraph(nodes)

    filenameFirstPart = os.path.basename(filename).replace(".md","")
    dotFileName = filenameFirstPart+".dot"
    pngFileName = filenameFirstPart+".png"
    #write_dot(graphs[filename],dotfolder + "/" + dotFileName)  # Ignoring dot files for now

    graph = to_pydot(graphs[filename])

    thePngFileName = "{}/{}".format(pngFolder,pngFileName)
    print("Write file {}".format(thePngFileName))
    try:
        graph.write_png(thePngFileName)
    except:
        print("Writing {} failed!!!".format(thePngFileName))


    # update readme
    generatedReadmeContents.append("[{}]({})".format(os.path.basename(filename),filename))
    generatedReadmeContents.append("")
    generatedReadmeContents.append('[<img src="generated/{}" width="600px">](./generated/{})'.format(pngFileName,pngFileName))
    generatedReadmeContents.append("")
    generatedReadmeContents.append("---")


# Add any ignored top level verbs
if len(allIgnoredRels)>0:
    generatedReadmeContents.append("")
    generatedReadmeContents.append("# Ignored Relationships")
    generatedReadmeContents.append("")
    generatedReadmeContents.append("The following top level relationships have been omitted from the diagrams due to preserve clarity:\n")
    generatedReadmeContents.append("| SubjectClass | Relationship | ObjectClass |")
    generatedReadmeContents.append("| ------------ | ------------ | ----------- |")
    for r in allIgnoredRels:
        generatedReadmeContents.append("| {} | {} | {} |".format(r[0],r[2]["label"],r[1]))



disconnectedNodes = []
for node in G:
    hasPath = nx.has_path(G,node,topLevelNode)
    if hasPath == False:
        disconnectedNodes.append(node)
        print("{} is missing path to {}".format(node,topLevelNode))

if len(disconnectedNodes)>0:
    generatedReadmeContents.append("")
    generatedReadmeContents.append("# Disconnected Nodes")
    generatedReadmeContents.append("")
    generatedReadmeContents.append("The following nodes do not have links to the toplevel node ({}):".format(topLevelNode))
    for node in disconnectedNodes:
        generatedReadmeContents.append("* {}".format(node))




with open(pngFolder.replace("/generated","")+"/README.md","w") as fp:
    fp.write("\n".join(generatedReadmeContents))


# create one diagram for 'everything'. Currently not included in the readme
filename = "everything"
dotFileName = filename+".dot"
pngFileName = filename+".png"
#write_dot(G,dotfolder + "/" + dotFileName)
graph = to_pydot(G)
try:
    graph.write_png(pngFolder+"/"+pngFileName)
except:
    print("Writing everything.png failed!!!")
