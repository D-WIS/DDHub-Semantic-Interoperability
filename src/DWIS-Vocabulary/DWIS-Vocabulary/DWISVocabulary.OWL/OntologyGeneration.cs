﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DWIS.Vocabulary.Development;
using DWIS.Vocabulary.Utils;
using RDFSharp.Model;
using RDFSharp.Semantics;

namespace DWIS.Vocabulary.OWL
{
    public static class OntologyGeneration
    {
        public static string DDHubPrefix = "http://ddhub.no/";

        private static RDFResource AttributeCardinalityRestriction = new RDFResource(DDHubPrefix + "DWISAttributeCardinalityRestriction");

        public static OWLOntology GetOntology(DWISVocabulary vocabulary)
        {
            string ontologyName = "DWISVocabulary";

            vocabulary.ToTrees(out Tree<Noun> nounTree, out Tree<Verb> verbTree);

            string versionInfo = "0.1";
            string comment = "This is the ontology generated by the D-WIS WG1: Semantics of Real-time signals. It has been automatically generated from the vocabulary defined at https://github.com/D-WIS/DDHub-Semantic-Interoperability/tree/main/docs/vocabulary_development/auto-generated";
            string label = "D-WIS vocabulary";
            string definedBy = "D-WIS WG1: Semantics of Real-time signals";
            string iri = "https://github.com/D-WIS/DDHub-Semantic-Interoperability/tree/main/docs/vocabulary_development/auto-generated/dwis.owl";


            RDFNamespaceRegister.AddNamespace(new RDFNamespace("ddhub", DDHubPrefix));

            OWLOntology ontology = new OWLOntology(new RDFResource(DDHubPrefix + ontologyName).ToString());

            ontology.Annotate(RDFVocabulary.RDFS.COMMENT, new RDFPlainLiteral(comment, "En"));
            ontology.Annotate(RDFVocabulary.OWL.VERSION_INFO,new RDFTypedLiteral(versionInfo, RDFModelEnums.RDFDatatypes.XSD_STRING));
            ontology.Annotate(RDFVocabulary.RDFS.LABEL, new RDFTypedLiteral(label, RDFModelEnums.RDFDatatypes.XSD_STRING));
            ontology.Annotate(RDFVocabulary.RDFS.IS_DEFINED_BY, new RDFTypedLiteral(definedBy, RDFModelEnums.RDFDatatypes.XSD_STRING));
            ontology.Annotate(RDFVocabulary.OWL.VERSION_IRI, new RDFTypedLiteral(iri, RDFModelEnums.RDFDatatypes.XSD_ANYURI));


            AddClass(nounTree, null, ontology);
            AddVerb(verbTree, null, ontology);

            return ontology;
        }

        public static OWLOntology ExportOntology(string fileName,DWISVocabulary vocabulary)
        {
            var ontology = GetOntology(vocabulary);

            WriteOntology(ontology, fileName);

            return ontology;
        }

        public static void WriteOntology(OWLOntology ontology, string fileName, bool includeModel = true)
        {           
            //RDFSemanticsEnums.RDFOntologyInferenceExportBehavior behavior = includeModel ? RDFSemanticsEnums.RDFOntologyInferenceExportBehavior.ModelAndData : RDFSemanticsEnums.RDFOntologyInferenceExportBehavior.OnlyData;
            //ontology.ToRDFGraph(behavior).ToFile(RDFModelEnums.RDFFormats.Turtle, fileName + ".ttl");
            //ontology.ToRDFGraph(behavior).ToFile(RDFModelEnums.RDFFormats.NTriples, fileName + ".nt");
            //ontology.ToRDFGraph(behavior).ToFile(RDFModelEnums.RDFFormats.RdfXml, fileName + ".xml");
            ontology.ToRDFGraph().ToFile(RDFModelEnums.RDFFormats.Turtle, fileName + ".ttl");
            ontology.ToRDFGraph().ToFile(RDFModelEnums.RDFFormats.NTriples, fileName + ".nt");
            ontology.ToRDFGraph().ToFile(RDFModelEnums.RDFFormats.RdfXml, fileName + ".xml");
        }
        public static RDFResource GetBaseTypeResource(string type)
        {
            return new RDFResource("http://www.w3.org/2001/XMLSchema#" + type.ToLower());
        }

        private static void AddClass(Tree<Noun> currentTree, RDFResource parent, OWLOntology ontology)
        {
            RDFResource current = new RDFResource( DDHubPrefix + currentTree.RootItem.Name);
            ontology.Model.ClassModel.DeclareClass(current);
            string description = string.Empty;
            if (currentTree.RootItem.Description != null && currentTree.RootItem.Description.Length > 0)
            {
                foreach (string desc in currentTree.RootItem.Description)
                {
                    description += desc + "\n";
                }
            }
            ontology.Model.ClassModel.AnnotateClass(current, RDFVocabulary.RDFS.COMMENT, new RDFPlainLiteral(description, "En"));
            //var current = new RDFOntologyClass(new RDFResource(DDHubPrefix + currentTree.RootItem.Name));
            //ontology.Model.ClassModel.AddClass(current);
            //ontology.Model.ClassModel.AddStandardAnnotation(RDFSemanticsEnums.RDFOntologyStandardAnnotation.Comment, current, new RDFOntologyLiteral(new RDFPlainLiteral(currentTree.RootItem.Description, "En")));

            if (parent != null)
            {
                ontology.Model.ClassModel.DeclareSubClasses(current, parent);
                //ontology.Model.ClassModel.AddSubClassOfRelation(current, parent);
            }
            if (currentTree.RootItem.NounAttributes != null)
            {
                foreach (var attribute in currentTree.RootItem.NounAttributes)
                {
                    RDFResource propertyResource = new RDFResource(DDHubPrefix + attribute.Name);
                   // RDFOntologyDatatypeProperty prop = new RDFOntologyDatatypeProperty(new RDFResource(DDHubPrefix +  attribute.Name));
                    ontology.Model.PropertyModel.DeclareDatatypeProperty(propertyResource, new OWLOntologyDatatypePropertyBehavior() {  Domain = current, Range = GetBaseTypeResource(attribute.Type), Functional = true });

                    ontology.Model.ClassModel.DeclareMinMaxQualifiedCardinalityRestriction(AttributeCardinalityRestriction, propertyResource, 1, 1, current);

                    //prop.SetDomain(current);
                    //prop.SetRange(GetBaseTypeResource(attribute.Type).ToRDFOntologyClass());                         
                    //prop.SetFunctional(true);

                    //ontology.Model.PropertyModel.
                    //RDFSharp.Model.RDFPropertyConstraint hjk = new RDFPropertyConstraint(null) {  };

                    //RDFOntologyCardinalityRestriction cardinalityRestriction = new RDFOntologyCardinalityRestriction(AttributeCardinalityRestriction, prop, 1, 1);
                    //ontology.Model.ClassModel.AddRestriction(cardinalityRestriction);
                    //ontology.Model.PropertyModel.AddStandardAnnotation(RDFSemanticsEnums.RDFOntologyStandardAnnotation.Comment, prop, new RDFOntologyLiteral(new RDFPlainLiteral(attribute.Description, "En")));
                    string attributeDescription = string.Empty;
                    if (attribute.Description != null)
                    {
                        foreach (string s in attribute.Description)
                        {
                            attributeDescription += s + "\n";
                        }
                    }
                    ontology.Model.PropertyModel.AnnotateProperty(propertyResource, RDFVocabulary.RDFS.COMMENT, new RDFPlainLiteral(attributeDescription, "En"));
                }
            }

            if (currentTree.Children != null)
            {
                foreach (var child in currentTree.Children)
                {
                    AddClass(child, current, ontology);
                }
            }
        }

        private static void AddVerb(Tree<Verb> currentTree, RDFResource parent, OWLOntology ontology)
        {
            
            var current = new RDFResource(DDHubPrefix + currentTree.RootItem.Name);

            OWLOntologyObjectPropertyBehavior behavior = new OWLOntologyObjectPropertyBehavior();
            behavior.Domain = new RDFResource(DDHubPrefix + currentTree.RootItem.DomainNounName);
            behavior.Range = new RDFResource(DDHubPrefix + currentTree.RootItem.RangeNounName);
            ontology.Model.PropertyModel.DeclareObjectProperty(current, behavior);
            string description = string.Empty;
            if (currentTree.RootItem.Description != null && currentTree.RootItem.Description.Length > 0)
            {
                foreach (string desc in currentTree.RootItem.Description)
                {
                    description += desc + "\n";
                }
            }
            ontology.Model.PropertyModel.AnnotateProperty(current, RDFVocabulary.RDFS.COMMENT, new RDFPlainLiteral(description, "En"));

            //ontology.Model.PropertyModel.AddProperty(current);

            //ontology.Model.PropertyModel.AddStandardAnnotation(RDFSemanticsEnums.RDFOntologyStandardAnnotation.Comment, current, new RDFOntologyLiteral(new RDFPlainLiteral(currentTree.RootItem.Description, "En")));

            if (parent != null)
            {
                ontology.Model.PropertyModel.DeclareSubProperties(current, parent);
            }


            //current.SetDomain(new RDFOntologyClass(new RDFResource(DDHubPrefix + currentTree.RootItem.DomainNounName)));
            //current.SetRange(new RDFOntologyClass(new RDFResource(DDHubPrefix + currentTree.RootItem.RangeNounName)));

            if (currentTree.RootItem.MinCardinality > 0 || currentTree.RootItem.MaxCardinality > 0)
            {
                ontology.Model.ClassModel.DeclareMinMaxQualifiedCardinalityRestriction(new RDFResource(DDHubPrefix + "DWSIVerbCardinalityRestriction" + currentTree.RootItem.Name), current, (uint)currentTree.RootItem.MinCardinality, (uint)currentTree.RootItem.MaxCardinality, new RDFResource(DDHubPrefix + currentTree.RootItem.DomainNounName));
                //RDFOntologyCardinalityRestriction cardinalityRestriction = new RDFOntologyCardinalityRestriction(new RDFResource(DDHubPrefix + "DWSIVerbCardinalityRestriction" + currentTree.RootItem.Name), current, currentTree.RootItem.MinCardinality, currentTree.RootItem.MaxCardinality);
                //ontology.Model.ClassModel.AddRestriction(cardinalityRestriction);
            }



            if (currentTree.Children != null)
            {
                foreach (var child in currentTree.Children)
                {
                    AddVerb(child, current, ontology);
                }
            }
        }

        private static RDFModelEnums.RDFDatatypes ConvertToLiteralType(string type)
        {
            switch (type.ToLower())
            {
                case "bool" or "boolean":
                    return RDFModelEnums.RDFDatatypes.XSD_BOOLEAN;
                case "int":
                    return RDFModelEnums.RDFDatatypes.XSD_INT;
                case "integer":
                    return RDFModelEnums.RDFDatatypes.XSD_INTEGER;
                case "float":
                    return RDFModelEnums.RDFDatatypes.XSD_FLOAT;
                case "double":
                    return RDFModelEnums.RDFDatatypes.XSD_DOUBLE;
                case "long":
                    return RDFModelEnums.RDFDatatypes.XSD_LONG;
                case "decimal":
                    return RDFModelEnums.RDFDatatypes.XSD_DECIMAL;
                case "short":
                    return RDFModelEnums.RDFDatatypes.XSD_SHORT;
                case "byte":
                    return RDFModelEnums.RDFDatatypes.XSD_BYTE;
                case "string":
                    return RDFModelEnums.RDFDatatypes.XSD_STRING;
                case "uint" or "unsignedint":
                    return RDFModelEnums.RDFDatatypes.XSD_UNSIGNEDINT;
                case "ulong" or "unsignedlong":
                    return RDFModelEnums.RDFDatatypes.XSD_UNSIGNEDLONG;

                default: return RDFModelEnums.RDFDatatypes.XSD_STRING;
            }


            // RDFSharp.Model.RDFVocabulary.XSD.FLOAT.ToRDFOntologyClass();
            return RDFModelEnums.RDFDatatypes.XSD_BOOLEAN;

        }


    

        public static OWLOntology AddInstance(OWLOntology ontology, DWISVocabulary vocabulary, DWISInstance instance)
        {
            foreach (var individual in instance.Population)
            {
                if (vocabulary.GetNoun(individual.TypeName, out Noun noun))
                {
                    RDFResource individualResource = new RDFResource(DDHubPrefix + individual.Name);
                    ontology.Data.DeclareIndividual(individualResource);
                    //var fact = new RDFOntologyFact(new RDFResource(DDHubPrefix +individual.Name));
                    //ontology.Data.AddFact(fact);
                    //var type = ontology.Model.ClassModel.SelectClass(DDHubPrefix + individual.TypeName);
                    ontology.Data.DeclareIndividualType(individualResource, new RDFResource(DDHubPrefix + individual.TypeName));//.AddClassTypeRelation(fact, type);

                    if (individual.Attributes != null)
                    {
                        var allAttributes = noun.GetAllAttributes(vocabulary);
                        foreach (var attribute in individual.Attributes)
                        {
                            if (!string.IsNullOrEmpty(attribute.AttributeValue))
                            {
                                string attributeType = allAttributes.FirstOrDefault(na => na.Name == attribute.AttributeName).Type;
                                string attributeValue = attribute.AttributeValue.Replace(",", ".");
                                if (System.Text.Encoding.UTF8.GetByteCount(attributeValue) == attributeValue.Length)
                                {
                                    RDFTypedLiteral literal = new RDFTypedLiteral(attributeValue, ConvertToLiteralType(attributeType));
                                    //ontology.Data.AddAssertionRelation(fact, (RDFOntologyDatatypeProperty)property, new RDFOntologyLiteral(literal));
                                    ontology.Data.DeclareDatatypeAssertion(individualResource, new RDFResource(DDHubPrefix + attribute.AttributeName), literal);
                                }
                                //  var property = ontology.Model.PropertyModel.SelectProperty(DDHubPrefix + attribute.AttributeName);                   
                            }
                        }
                    }
                }
            }

            foreach (var ca in instance.ClassAssertions)
            {
                RDFResource individualResource = new RDFResource(DDHubPrefix + ca.Subject);
                ontology.Data.DeclareIndividualType(individualResource, new RDFResource(DDHubPrefix + ca.Class));

                //var type = ontology.Model.ClassModel.SelectClass(DDHubPrefix + ca.Class);
                //var fact = ontology.Data.SelectFact(DDHubPrefix + ca.Subject);
                //ontology.Data.AddClassTypeRelation(fact, type);
            }

            foreach (var sentence in instance.Sentences)
            {
                ontology.Data.DeclareObjectAssertion(new RDFResource(DDHubPrefix + sentence.Subject), new RDFResource(DDHubPrefix + sentence.Verb), new RDFResource(DDHubPrefix + sentence.Object));

                //var verb = ontology.Model.PropertyModel.SelectProperty(DDHubPrefix + sentence.Verb);
                //var subjectFact = ontology.Data.SelectFact(DDHubPrefix +  sentence.Subject);
                //var objectFact = ontology.Data.SelectFact(DDHubPrefix + sentence.Object);
                //ontology.Data.AddAssertionRelation(subjectFact, (RDFOntologyObjectProperty)verb, objectFact);
            }

            return ontology;
        }

    }
}
