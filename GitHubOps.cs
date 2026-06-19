using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GitHubAutoUploader;

public class GitHubOps
{
      private const string Base = "https://github.com";
      private const string ApiBase = "https://api.github.com";

      private const int MinDelayMs = 3000;
      private const int MaxDelayMs = 6000;
      private const int LongMinDelayMs = 6000;
      private const int LongMaxDelayMs = 12000;

      private static read
