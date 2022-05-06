using System;
using System.Linq;
namespace nsxtalbsdk
{
    public static class FormattingExtentions
    {
        public static string ToLowerString(this bool? _bool)
        {
            return _bool?.ToString()?.ToLowerInvariant() ?? "false";
        }
        public static string ToLowerString(this string? _string)
        {
            return _string ?? string.Empty;
        }
        public static string ToLowerString(this int? _int)
        {
            return _int.ToString() ?? string.Empty;
        }
    }
}
