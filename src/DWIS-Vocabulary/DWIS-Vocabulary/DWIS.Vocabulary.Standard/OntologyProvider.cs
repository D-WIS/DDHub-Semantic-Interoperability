using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;

namespace DWIS.Vocabulary.Standard
{
    public static class OntologyProvider
    {
        private static RDFOntology _dwisOntology;
        public static RDFOntology GetDWISOntology()
        {
            return DWIS.Vocabulary.OWL.OntologyGeneration.GetOntology(VocabularyProvider.Vocabulary);
        }

        public static RDFOntology DWISOntology
        {
            get 
            {
                if (_dwisOntology == null) { _dwisOntology = GetDWISOntology(); }
                return _dwisOntology;
            }
        }
    }
}
