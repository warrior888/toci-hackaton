using System.Diagnostics;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.Generator.Core.Interfaces.Entities
{
    public interface ICodeSnippet<in TSource, out TParseResult> : IFIleParser<TSource, TParseResult> 
        where TParseResult : IParseResult
        where TSource : IFileSource
    {
        string Snippet { get; set; }
    }
}