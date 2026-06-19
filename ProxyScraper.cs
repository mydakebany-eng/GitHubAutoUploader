using System.Collections.Concurrent;
using System.Net;

namespace GitHubAutoUploader;

public static class ProxyScraper
{
      private static readonly string[] Sources =
            [
                "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=http&timeout=10000&country=all&ssl=all&anonymity=all",
                "https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/http.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/http.txt",
                "https://raw.githubu
