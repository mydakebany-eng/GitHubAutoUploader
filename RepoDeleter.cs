using Microsoft.Playwright;

namespace GitHubAutoUploader;

public static class RepoDeleter
{
      public static async Task<bool> DeleteAsync(string cookieFilePath, string username, string repoName)
      {
                using var playwright = await Playwright.CreateAsync();
                await using var browser = await playwright.Chromium.LaunchAsync(new()
                                                                                {
                                                                                              Headless = true,
                                                                                              Args = ["--disable-blink-features=AutomationControlled"],
                                                                                });

                var context = await brows
