using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.Generator.Core.Interfaces.Entities;

namespace Toci.Generator.Core.Interfaces.Tools
{
    public interface ISnippetParser<in TFileSource, out TParseResult>
        where TFileSource : IFileSource
        where TParseResult : IParseResult
    {
        ICodeSnippet<TFileSource, TParseResult> GetSnippet(IFileSource path);
    }
}
