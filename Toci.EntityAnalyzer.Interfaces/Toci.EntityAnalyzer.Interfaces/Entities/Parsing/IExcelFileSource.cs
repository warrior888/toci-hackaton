using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities.Parsing
{
    public interface IExcelFileSource : ITextFileSource
    {
        List<string> Sheets { get; set; }
    }
}