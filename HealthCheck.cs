using System.Net;

namespace GitHubAutoUploader;

public static class HealthCheck
{
      private static readonly HttpClient _anonClient = CreateAnonClient();

      private static HttpClient CreateAnonClient()
      {
                var handler = new HttpClientHandler
                {
                              AllowAutoRedirect = true,
                              AutomaticDecompression = DecompressionMethods.All,
                };
                var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(15) };
                client.DefaultRequestHeaders
