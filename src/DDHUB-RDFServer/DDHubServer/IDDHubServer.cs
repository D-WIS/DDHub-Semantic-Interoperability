using System.Linq;
using VDS.RDF;

namespace DDHubServer
{
    public interface IDDHubServer
    {
        IGraph GetQueryResults(string query);
        bool GetQueryResults(string query, out string results);
        bool GetGraph(out string results);

    }
}
