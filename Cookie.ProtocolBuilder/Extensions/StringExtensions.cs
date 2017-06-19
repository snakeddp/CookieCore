using System.IO;
using System.Text.RegularExpressions;

namespace Cookie.ProtocolBuilder.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string s)
            => s.Substring(0, 1).ToUpper() +
               s.Substring(1, s.Length - 1);

        public static string Decapitalize(this string s)
            => s.Substring(0, 1).ToLower() +
               s.Substring(1, s.Length - 1);

        public static bool IsValidPath(this string path)
        {
            var driveCheck = new Regex(@"^[a-zA-Z]:\\$");
            if (!driveCheck.IsMatch(path.Substring(0, 3))) return false;
            var strTheseAreInvalidFileNameChars = new string(Path.GetInvalidPathChars());
            strTheseAreInvalidFileNameChars += @":/?*" + "\"";
            var containsABadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");
            if (containsABadCharacter.IsMatch(path.Substring(3, path.Length - 3)))
                return false;

            var dir = new DirectoryInfo(Path.GetFullPath(path));
            if (!dir.Exists)
                dir.Create();
            return true;
        }
    }
}
