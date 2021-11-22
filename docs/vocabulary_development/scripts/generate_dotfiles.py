from dotenv import load_dotenv
import os
import glob
import networkx as nx
from networkx.drawing.nx_pydot import write_dot
import pydot
from networkx.drawing.nx_pydot import to_pydot
from networkx.drawing.nx_pydot import pydot_layout


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

print(folder)


def parseContents(contents):
    nodes = []
    relationships = []
    noun = None
    lines = contents.split("\n")
    for line in lines:
        #print(line)
        if line.startswith("##") and line.endswith("<!-- NOUN -->"):
            noun = line.replace("##","").replace("<!-- NOUN -->","").strip()
            if noun not in nodes:
                nodes.append(noun)
        elif line.startswith("- Parent class:") and noun!=None:
            parentClass = line[line.find("[")+1:line.find("]")]
            if parentClass not in nodes:
                nodes.append(parentClass)
            r = [noun,parentClass,{'label':"SUBCLASS_OF"}]
            relationships.append(r)
            
        #print(line)
    return nodes,relationships
            

G = nx.DiGraph()
graphs = {}
fileNodes = {}

allNodes = []
allRels = []

filenames = glob.glob(folder+"/*.md")
for filename in filenames:
    with open(filename,"r") as fp:
        print("Reading '{}'".format(filename))
        fileContent = fp.read()
        nodes, relationships = parseContents(fileContent)

        #print(relationships)
        fileNodes[filename] = nodes
        allNodes.extend(nodes)
        allRels.extend(relationships)

print("Populate Graph")

allNodes = list(set(allNodes))
allNodes.sort()

G.add_nodes_from(allNodes)
G.add_edges_from(allRels)


# print("neightbours of MathematicalModel")
# for n in G.neighbors("MathematicalModel"):
#     print(n)

# for n in G.neighbors("MathematicalModel"):
#     print(n)

print("Generate files")

generatedReadmeContents = []
generatedReadmeContents.append("# Generated Diagrams")
generatedReadmeContents.append("")

for filename in filenames:
    nodes = fileNodes[filename]
    graphs[filename] = G.subgraph(nodes)

    #print(len(nodes),len(graphs[filename]))
        
    filenameFirstPart = os.path.basename(filename).replace(".md","")
    dotFileName = filenameFirstPart+".dot"
    pngFileName = filenameFirstPart+".png"
    write_dot(graphs[filename],dotfolder + "/" + dotFileName)

    graph = to_pydot(graphs[filename])
    graph.write_png(pngFolder+"/"+pngFileName)

    generatedReadmeContents.append("[{}]({})".format(os.path.basename(filename),filename))
    generatedReadmeContents.append("")
    generatedReadmeContents.append('[<img src="generated/{}" width="600px">](./generated/{})'.format(pngFileName,pngFileName))
    generatedReadmeContents.append("")
    generatedReadmeContents.append("---")


with open(pngFolder.replace("/generated","")+"/README.md","w") as fp:
    fp.write("\n".join(generatedReadmeContents))

filename = "everything"
dotFileName = filename+".dot"
pngFileName = filename+".png"
write_dot(G,dotfolder + "/" + dotFileName)
graph = to_pydot(G)
graph.write_png(pngFolder+"/"+pngFileName)
