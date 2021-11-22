using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {
        private HttpClient _httpClient;
        private HttpClientHandler _httpClientHandler;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<string[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task<string[]>.Run(() => GetAsync_("http://localhost:8888/graph").Result.Split('\r', '\n', StringSplitOptions.RemoveEmptyEntries));


        }

        private static string NormalizeBaseUrl(string url)
        {
            return url.EndsWith("/") ? url : url + "/";
        }
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);
        private const string ClientUserAgent = "basic-ddhub-api-client-v1";
        private const string MediaTypeJson = "application/json";
        private readonly string _baseUrl = "http://localhost:8080";


        public Task<string> GetAsync_(string url)
        {
            EnsureHttpClientCreated();

            using (var response = _httpClient.GetAsync(url).Result)
            {
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync();
            }
        }

        private void CreateHttpClient()
        {
            _httpClientHandler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            };

            _httpClient = new HttpClient(_httpClientHandler, false)
            {
                Timeout = _timeout
            };

            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(ClientUserAgent);

            if (!string.IsNullOrWhiteSpace(_baseUrl))
            {
                _httpClient.BaseAddress = new Uri(_baseUrl);
            }

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeJson));
        }

        private void EnsureHttpClientCreated()
        {
            if (_httpClient == null)
            {
                CreateHttpClient();
            }
        }
    }
}
