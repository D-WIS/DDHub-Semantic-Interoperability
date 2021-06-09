using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Writing;

namespace InMemoryDDHubServer
{
    public class InMemoryDDHubServer
    {

        private OntologyGraph _ontologyGraph = new OntologyGraph();
        private TripleStore _tripleStore = new TripleStore();
        private object _lock = new object();

        private string _loggingDirectory = "./";
        private string _loggingName = "DDHub_";
        private bool _log = true;

        private string GetLoggingFileName(DateTime date)
        {
            return _loggingDirectory + _loggingName + date.Year.ToString("0000") + date.Month.ToString("00") + date.Day.ToString("00") + date.Hour.ToString("00") + date.Minute.ToString("00") + date.Second.ToString("00") + ".owl";
        }

        private void Log(DateTime date)
        {
            string s = SerializeAsync().Result;
            System.IO.File.WriteAllText(GetLoggingFileName(date), s);
        }
        private InMemoryDDHubServer()
        {
            _tripleStore.Add(_ontologyGraph);
        }

        public static InMemoryDDHubServer CreateFromFile(string fileName, bool log = true, string loggingDirectory = "./", string loggingName = "DDHub_")
        {
            InMemoryDDHubServer server = new InMemoryDDHubServer() { _log = log, _loggingDirectory = loggingDirectory, _loggingName = loggingName };
            if (server.LoadFromFile(fileName))
            {
                return server;
            }
            return null;
        }

        private bool LoadFromFile(string fileName)
        {
            try
            {
                VDS.RDF.Parsing.FileLoader.Load(_ontologyGraph, fileName, new TurtleParser());
            }
            catch (Exception e)
            {
                return false;
            }
            if (_log)
            {
                Log(DateTime.Now);
            }
            return true;
        }

        public async Task<bool> AddAsync(IEnumerable<Triple> triples)
        {
            return await Task.Run(() => Add(triples));
        }

        public bool Add(IEnumerable<Triple> triples)
        {
            bool res = triples != null;
            if (res)
            {
                lock (_lock)
                {
                    res = _ontologyGraph.Assert(triples);
                }
            }
            if (res && _log)
            {
                Log(DateTime.Now);
            }
            return res;
        }

        public async Task<bool> RemoveAsync(IEnumerable<Triple> triples)
        {
            return await Task.Run(() => Remove(triples));
        }

        public bool Remove(IEnumerable<Triple> triples)
        {
            bool res = triples != null;
            if (res)
            {
                lock (_lock)
                {
                    res = _ontologyGraph.Retract(triples);
                }
            }
            if (res && _log)
            {
                Log(DateTime.Now);
            }
            return res;
        }
        public async Task<string> SerializeAsync()
        {
            return await Task.Run(() => Serialize());
        }
        public string Serialize()
        {
            string result = string.Empty;
            lock (_lock)
            {
                RdfXmlWriter rdfxmlwriter = new RdfXmlWriter();
                using (System.IO.StringWriter writer = new System.IO.StringWriter())
                {
                    _ontologyGraph.SaveToStream(writer, rdfxmlwriter);
                    result = writer.ToString();
                }
            }
            return result;
        }

        public async Task<IGraph> GetQueryResultsAsync(SparqlQuery query)
        {
            return await Task.Run(() => GetQueryResults(query));
        }

        public IGraph GetQueryResults(string query)
        {
            SparqlQueryParser sparqlparser = new SparqlQueryParser();
            return GetQueryResults(sparqlparser.ParseFromString(query));
        }

        public bool GetQueryResults(string query, out string results)
        {
            SparqlQueryParser sparqlparser = new SparqlQueryParser();
            results = PrintGraph(GetQueryResults(sparqlparser.ParseFromString(query)));
            return results != string.Empty;
        }

        public IGraph GetQueryResults(SparqlQuery query)
        {
            IGraph res = null;

            lock (_lock)
            {
                ISparqlQueryProcessor processor = new LeviathanQueryProcessor(_tripleStore);

                //Use the SparqlQueryParser to give us a SparqlQuery object
                //Should get a Graph back from a CONSTRUCT query
                object v = processor.ProcessQuery(query);
                if (v is IGraph)
                {
                    res = (IGraph)v;
                }
            }

            return res;
        }

        public static string PrintGraph(IGraph graph)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var t in graph.Triples)
            {
                stringBuilder.AppendLine(t.ToString());
            }
            return stringBuilder.ToString();
        }

        //public static void PrintGraph(IGraph graph)
        //{
        //    foreach (var t in graph.Triples)
        //    {
        //        Console.WriteLine(t);
        //    }
        //}
    }
}
