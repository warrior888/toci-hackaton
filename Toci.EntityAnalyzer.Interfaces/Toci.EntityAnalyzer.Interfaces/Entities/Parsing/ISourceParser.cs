using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities.Parsing
{
    public interface ISourceParser<in TSource, out TParseResult> 
        where TSource : ISource 
        where TParseResult : IParseResult
    {
        IEnumerable<TParseResult> Parse(TSource source);
    }
}