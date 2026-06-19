using System.Net;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace GitHubAutoUploader;

public class GitHubSession : IDisposable
{
    private readonly CookieContainer _cookies = new();
        private readonly HttpClientHandler _handler;
            private readonly HttpClient _http;

                public string Username { get; set; } = "";
                    public string AuthType { get; set; } = "";
                        public string? Token { get; set; }
                            public List<string> Repos { get; set; } = [];

                                privat
