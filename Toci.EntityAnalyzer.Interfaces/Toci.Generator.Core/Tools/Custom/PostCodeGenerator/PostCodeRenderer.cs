using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.Generator.Core.Interfaces.Entities;

namespace Toci.Generator.Core.Tools.Custom.PostCodeGenerator
{
    public class PostCodeRenderer<TCodeSnippet, TParseResult> : CodeRenderer<TCodeSnippet, TParseResult> 
        where TCodeSnippet : ICodeSnippet
        where TParseResult : IPostCodeEntity
    {
        public PostCodeRenderer()
        {
            SnippetRenderMapping = new Dictionary<string, Func<TParseResult, TCodeSnippet, string>>
            {
                {
                    CodeSnippetConsts.AccessModifier,
                    (result, snippet) => snippet.Snippet.Replace(CodeSnippetConsts.AccessModifier, "public")
                },
                {
                    CodeSnippetConsts.StaticConst,
                    (result, snippet) => snippet.Snippet.Replace(CodeSnippetConsts.StaticConst, "const")
                },
                {
                    CodeSnippetConsts.Type,
                    (result, snippet) => snippet.Snippet.Replace(CodeSnippetConsts.Type, "string")
                },
                {
                    CodeSnippetConsts.Name,
                    (result, snippet) => snippet.Snippet.Replace(CodeSnippetConsts.Name, result.Address)
                },
                {
                    CodeSnippetConsts.Value,
                    (result, snippet) => snippet.Snippet.Replace(CodeSnippetConsts.Value, result.PostCode)
                }
            };

        }
        
    }
}