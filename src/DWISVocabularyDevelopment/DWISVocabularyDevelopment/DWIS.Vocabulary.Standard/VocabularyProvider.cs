using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.Vocabulary.Standard
{
    public static class StandardSetProvider
    {
        private static string _unitsAndQuantitiesInstanceFile = @"UnitsAndQuantities.json";
        private static DWIS.Vocabulary.Development.DWISInstance _unitsAndQuantities = null;
        public static DWIS.Vocabulary.Development.DWISInstance UnitsAndQuantities
        {
            get
            {
                if (_unitsAndQuantities == null) { _unitsAndQuantities = GetUnitsAndQuantities(); }
                return _unitsAndQuantities;
            }
        }
        public static void SetUnitsAndQuantitiesFile(string file)
        {
            _unitsAndQuantitiesInstanceFile = file;
        }
        public static DWIS.Vocabulary.Development.DWISInstance GetUnitsAndQuantities()
        {
            if (Utils.VocabularyParsing.FromMDFileContents(Properties.Resources.UnitsAndQuantities.Split("\r\n"), "UnitsAndQuantities",VocabularyProvider.Vocabulary, out var uq))
            {
                return uq;
            }
            else return null;
        }
    }



    public static class VocabularyProvider
    {
        private static string _vocabularyJsonFileName =  @"DWISVocabulary.json";

        private static Development.DWISVocabulary _vocabulary = null;

        public static Development.DWISVocabulary Vocabulary
        {
            get 
            {
                if (_vocabulary == null) { _vocabulary = GetDWISVocabulary(); }
                return _vocabulary;
            }
        }


      


        public static void SetVocabularyJsonFile(string fileName)
        {
            _vocabularyJsonFileName = fileName;
        }

      

        public static Development.DWISVocabulary GetDWISVocabulary()
        {
            return DWIS.Vocabulary.Development.DWISVocabulary.FromJsonString(Properties.Resources.DWISVocabulary);
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
