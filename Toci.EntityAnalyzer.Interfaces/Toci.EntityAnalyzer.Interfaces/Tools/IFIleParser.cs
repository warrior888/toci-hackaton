using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IFIleParser<in TSource, out TParseResult> : ISourceParser<TSource, TParseResult> 
        where TSource : IFileSource
        where TParseResult : IParseResult
    {
         
    }
}