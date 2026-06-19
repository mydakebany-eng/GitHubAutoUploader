using System.Text.RegularExpressions;

namespace GitHubAutoUploader;

public static class BanwordFilter
{
      private static readonly string[] Banwords =
            [
                "crack", "cracked", "cracking", "cracker",
                "keygen", "key generator", "license key", "serial key", "activation key", "product key",
                "activator", "activate", "activation",
                "patcher", "patched", "patch", "nulled", "warez", "pirate", "pirated",
                "loader", "injector", "inject", "injection",
                "hack
