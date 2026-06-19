using System.Net;
using Microsoft.Playwright;

namespace GitHubAutoUploader;

public class BrowserRepoCreator : IAsyncDisposable
{
    private IPlaywright? _playwright;
        private IBrowser? _browser;

            public async Task InitAsync()
                {
                        _playwright = await Playwright.CreateAsync();
                                _browser = await _playwright.Chromium.LaunchAsync(new()
                                        {
                                                    Headless = true,
                                                                Args = ["--disable-blink-features=AutomationControlled"]
                                                                        });
                                                                            }

                                                                                public as
