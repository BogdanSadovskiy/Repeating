using System.Text.RegularExpressions;

namespace Repeat
{
    internal class RegexStr
    {
        private static string patternForNumbers = "^([\\d])+$";
        private static bool isMatch(string str, string pattern)
        {
            if (str == null) return false;
            if (Regex.IsMatch(str, pattern)) return true;
            return false;
        }
        public static bool isOnlyNumbers(string str)
        {
            return isMatch(str, patternForNumbers);
        }
    }
}
