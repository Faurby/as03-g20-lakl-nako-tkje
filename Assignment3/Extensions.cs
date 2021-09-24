using System;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool isSecure(this Uri u) => u.ToString().StartsWith("https");

        public static int WordCount(this string s) =>  Regex.Matches(s, @"\p{L}+").Count;

    }
}
