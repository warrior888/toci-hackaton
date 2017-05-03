using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Entities.Parsing
{
    public class ExcelFileSource : IExcelFileSource
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public List<string> Sheets { get; set; }
    }
}