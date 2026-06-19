using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GitHubAutoUploader;

public class ReleaseManager
{
      private const string ApiBase = "https://api.github.com";

      public async Task<string?> CreateReleaseWithFileAsync(
                GitHubSession session, string owner, string repo,
                string tagName, string releaseFilePath, string? uploadName = null)
      {
                if (!session.HasToken)
                {
                         
