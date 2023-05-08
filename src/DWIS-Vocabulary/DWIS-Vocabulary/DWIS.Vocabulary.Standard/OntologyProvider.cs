using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDFSharp.Model;
using RDFSharp.Semantics;

namespace DWIS.Vocabulary.Standard
{
    public static class OntologyProvider
    {
        private static OWLOntology _dwisOntology;
        public static OWLOntology GetDWISOntology()
        {
            return DWIS.Vocabulary.OWL.OntologyGeneration.GetOntology(VocabularyProvider.Vocabulary);
        }

        public static OWLOntology DWISOntology
        {
            get 
            {
                if (_dwisOntology == null) { _dwisOntology = GetDWISOntology(); }
                return _dwisOntology;
            }
        }
    }
}
