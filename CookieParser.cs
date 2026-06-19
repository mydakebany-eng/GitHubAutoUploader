using System.Net;
using System.Text.Json;

namespace GitHubAutoUploader;

public static class CookieParser
{
      public static bool TryParse(string filePath, CookieContainer container, out int count)
      {
                count = 0;
                if (!File.Exists(filePath))
                {
                              Console.WriteLine($"  [-] Cookie file not found: {filePath}");
                              return false;
                }

                var content = File.ReadAllText(filePath).Trim();

                try
                {
                              if (content.StartsWith('[
