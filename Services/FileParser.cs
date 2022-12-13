using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using victoria3_file_scraper.Helper;
using victoria3_file_scraper.Models;

namespace victoria3_file_scraper.Services
{
    internal class FileParser : Parser
    {
        private FileLines FileLines;
        public async Task ParseAsync()
        {
            
            throw new NotImplementedException();
        }
        private LineType ParseLineAsync(string line)
        {
            line = line.ReplaceWhitespace();
            var isComment = line.First() == '#';
            if (isComment) return LineType.Comment;

            var isGroup = line.Contains('=') && line.Contains('{');
            if (isGroup) return LineType.Group;

            var isValue = line.Contains('=') && !line.Contains('{');
            if (isValue) return LineType.Value;

            return LineType.Unknown;
        }

        private async Task<KeyValuePair<string, string>> GetValueLine(string line)
        {
            var splitLine = line.Replace(" ", "").Split('=');
            var key = splitLine[0];
            var value = splitLine[1];

            return KeyValuePair.Create(key, value);
        }

    }
}
