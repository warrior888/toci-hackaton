using System;
using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.Tools;
using Toci.Generator.Core.Interfaces.Entities;
using Toci.Generator.Core.Interfaces.Tools;
using Toci.Generator.Core.Tools.Custom.PostCodeGenerator;
using IClassCode = Toci.Generator.Core.Interfaces.Entities.IClassCode;

namespace Toci.Generator.Core.Tools
{
    public abstract  class CodeRenderer<TCodeSnippet, TParseResult> : ICodeRenderer<TCodeSnippet, TParseResult>
        where TParseResult : IParseResult
        where TCodeSnippet : ICodeSnippet
    {
        protected Dictionary<string, Func<TParseResult, TCodeSnippet, string>> SnippetRenderMapping;
        
        public virtual ICodeFragment CreateCodeFragment(TParseResult parseResult, TCodeSnippet codeSnippet)
        {
            ICodeFragment cf = new CodeFragment();

            foreach (var element in SnippetRenderMapping)
            {
                codeSnippet.Snippet = element.Value(parseResult, codeSnippet);
            }

            cf.CodeLine = codeSnippet.Snippet;

            return cf;
        }

        public IClassCode CreateClassCode<TClassCode, TCodeFragment>(TClassCode classCode, TCodeFragment codeFragment)
        {
            throw new System.NotImplementedException();
        }
        
    }
}