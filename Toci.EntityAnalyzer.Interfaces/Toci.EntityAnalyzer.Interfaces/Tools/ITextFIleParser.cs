using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface ITextFIleParser<in TSource, out TParseResult> : IFIleParser<TSource, TParseResult>
        where TSource : ITextFileSource
        where TParseResult : IParseResult
    {
         
    }
}