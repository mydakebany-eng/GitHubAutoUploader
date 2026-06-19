using System.IO.Compression;

namespace GitHubAutoUploader;

public record ZipContent(string RepoName, string About, List<string> Tags, Dictionary<string, byte[]> Files);

public static class ZipTemplate
{
      public static ZipContent Load(string zipPath)
      {
                var files = new Dictionary<string, byte[]>();
                string name = "";
                string about = "";
                var tags = new List<string>();

                using var zip = ZipFile.OpenRead(zipPath);
                foreach (var entry in zip.Entrie
