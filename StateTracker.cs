namespace GitHubAutoUploader;

public static class StateTracker
{
      private static readonly object _lock = new();

      public static HashSet<string> LoadDone(string filepath = "done.txt")
      {
                var done = new HashSet<string>();
                try
                {
                              foreach (var line in File.ReadAllLines(filepath))
                              {
                                                var trimmed = line.Trim();
                                                if (!string.IsNullOrEmpty(trimmed))
                                                                      done.Add(trimmed);
                              }
                }
              
