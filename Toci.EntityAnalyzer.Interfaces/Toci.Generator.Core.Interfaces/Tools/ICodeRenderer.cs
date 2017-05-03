using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.Generator.Core.Interfaces.Entities;
using IClassCode = Toci.Generator.Core.Interfaces.Entities.IClassCode;

namespace Toci.Generator.Core.Interfaces.Tools
{
    public interface ICodeRenderer<in TCodeSnippet,in TParseResult> 
        where TCodeSnippet : ICodeSnippet<IFileSource,IParseResult>
        where TParseResult : IParseResult
    {
        ICodeFragment CreateCodeFragment(TParseResult parseResult, TCodeSnippet codeSnippet);
        IClassCode CreateClassCode<TClassCode, TCodeFragment>(TClassCode classCode, TCodeFragment codeFragment);
    }
}