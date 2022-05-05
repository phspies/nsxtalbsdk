using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return _string ?? "";
        }
        public static string ToLowerString(this int? _int)
        {
            return _int.ToString() ?? "";
        }
    }
}
