using Microsoft.Playwright;

namespace GitHubAutoUploader;

public static class BrowserLogin
{
      public static async Task RunAsync(string cookiesFolder)
      {
                Console.WriteLine("[*] Opening browser for GitHub login...");
                Console.WriteLine("[*] Log in, then the browser will close automatically.");
                Console.WriteLine();

                using var playwright = await Playwright.CreateAsync();
                await using var browser = await playwright.Chromium.LaunchAsync(new()
                                                                                {
                                                                                     
