using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.Vocabulary.Standard
{
    public static class VocabularyProvider
    {
        private static string _folder = FindDWISFolder() + @"\DDHub-Semantic-Interoperability\docs\vocabulary_development\auto-generated\md\definition-files\";
        private static string _unitsAndQuantitiesInstanceFile = string.Empty;

        private static Development.DWISVocabulary _vocabulary = null;
        private static DWIS.Vocabulary.Development.DWISInstance _unitsAndQuantities = null;

        public static Development.DWISVocabulary Vocabulary
        {
            get 
            {
                if (_vocabulary == null) { _vocabulary = GetDWISVocabulary(); }
                return _vocabulary;
            }
        }


        public static DWIS.Vocabulary.Development.DWISInstance UnitsAndQuantities
        {
            get
            {
                if (_unitsAndQuantities == null) { _unitsAndQuantities = GetUnitsAndQuantities(); }
                return _unitsAndQuantities;
            }
        }


        public static void SetVocabularyFolder(string folder)
        {
            _folder = folder;
        }

        public static void SetUnitsAndQuantitiesFile(string file)
        {
            _unitsAndQuantitiesInstanceFile = file;
        }

        public static Development.DWISVocabulary GetDWISVocabulary()
        {
            if (Utils.VocabularyParsing.FromFolder(_folder, out var vocabulary))
            {
                return vocabulary;
            }
            else return null;
        }

        public static DWIS.Vocabulary.Development.DWISInstance GetUnitsAndQuantities()
        {
            if (Utils.VocabularyParsing.FromMDFile(_unitsAndQuantitiesInstanceFile, Vocabulary, out var uq))
            {
                return uq;
            }
            else return null;
        }


        private static string FindDWISFolder()
        {
            string dwis = "D-WIS";
            string dir = System.IO.Directory.GetCurrentDirectory();
            if (dir.Contains(dwis))
            {
                int idx = dir.IndexOf(dwis);
                return dir.Remove(idx + dwis.Length, dir.Length - idx - dwis.Length);

            }
            return string.Empty;
        }
    }
}
