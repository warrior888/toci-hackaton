using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IExcelFIleParser<in TSource, out TParseResult> : IFIleParser<TSource, TParseResult>
        where TSource : IExcelFileSource
        where TParseResult : IParseResult
    {
         
    }
}