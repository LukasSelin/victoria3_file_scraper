using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace victoria3_file_scraper.Helper
{
    internal static class StringExtensions
    {

        private static readonly Regex sWhitespace = new(@"\s+");
        public static string ReplaceWhitespace(this string input, string replacement = "")
        {
            return sWhitespace.Replace(input, replacement);
        }
    }
}
