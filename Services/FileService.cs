using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace victoria3_file_scraper.Services
{
    internal class FileService
    {
        public async Task<string[]> ReadLinesFileAsync()
        {
            string[] lines = await System.IO.File.ReadAllLinesAsync(@"C:\Users\Public\TestFolder\WriteLines2.txt");
            return lines;
        }
    }
}
