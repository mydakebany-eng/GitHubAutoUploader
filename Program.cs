using System.Collections.Concurrent;
using System.Net;
using GitHubAutoUploader;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var mode = args.Length > 0 ? args[0] : "";

// login mode — open visible browser, user logs in, cookies saved
if (mode == "--login")
{
      var cfg = await ConfigHelper.LoadAsync("config.json");
      await BrowserLogin.RunAsync(cfg.CookiesFolder);
      return;
}

// test mode
if (mode == "--test")
{
      var cfg = await ConfigHelper.LoadAsync("config.json");
      var 
