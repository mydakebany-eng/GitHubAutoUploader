using Microsoft.Playwright;

namespace GitHubAutoUploader;

public static class TestBrowser
{
      public static async Task RunAsync(string cookieDir, string proxyStr)
      {
                // use my_github_cookies.txt if exists
                var myFile = @"C:\Users\kolob\OneDrive\Desktop\github\my_github_cookies.txt";
                string? cookieFile = File.Exists(myFile) ? myFile
                              : Directory.GetFiles(cookieDir, "*.txt").First();

                Console.WriteLine($"[TEST] Cookie: {Path.GetFileName(cookieFile)}
