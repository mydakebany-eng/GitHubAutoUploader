using System.Net;

namespace GitHubAutoUploader;

public class AccountManager
{
      private readonly BoostManager _boost = new();
      private readonly ReleaseManager _release = new();

      // ═══════════════════════════════════════════════
      //  DRIP MODE — 3-8 repos/day with 1-4h intervals
      // ═══════════════════════════════════════════════

      public async Task DripCreateAsync(
                Func<string, string, WebProxy?, Task<bool>> uploadFunc,
                List<(string username, string token)> s
