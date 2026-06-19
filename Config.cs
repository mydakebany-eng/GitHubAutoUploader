using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitHubAutoUploader;

public class AppConfig
{
      [JsonPropertyName("cookiesFolder")]
      public string CookiesFolder { get; set; } = "cookies";

      [JsonPropertyName("projectsFolder")]
      public string ProjectsFolder { get; set; } = "projects";

      [JsonPropertyName("branch")]
      public string Branch { get; set; } = "main";

      [JsonPropertyName("commitMessage")]
      public string CommitMessage { get; set; } = "Initia
