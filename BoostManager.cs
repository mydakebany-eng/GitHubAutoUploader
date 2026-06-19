using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GitHubAutoUploader;

public partial class BoostManager
{
      private const string ApiBase = "https://api.github.com";
      private readonly ReleaseManager _release = new();

      private static readonly string[] PopularRepos =
            [
                "torvalds/linux", "microsoft/vscode", "golang/go", "rust-lang/rust",
                "python/cpython", "nodejs/node", "flutter/flutter", "facebook/react",
            
