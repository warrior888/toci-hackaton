using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Tools.PostCodeParser;
using Toci.Generator.Core.Interfaces.Entities;
using Toci.Generator.Core.Interfaces.Tools;
using Toci.Generator.Core.Tools;
using Toci.Generator.Core.Tools.CodeSnippets;
using Toci.Generator.Core.Tools.Custom.PostCodeGenerator;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.PostCodeRenderer
{
    [TestClass]
    public class CodeRendererTest
    {

        [TestMethod]
        public void CodeRender()
        {
            PostCodeTextFileParser<TextFileSource, PostCodeEntity> test = new PostCodeTextFileParser<TextFileSource, PostCodeEntity>();
            ITextFileSource source = new TextFileSource { FilePath = @"Z:\", FileName = "kody.csv" };
            var postcodeEntities = test.Parse((TextFileSource)source);

            CodeRenderer<ConstCodeSnippet, PostCodeEntity> renderer = new PostCodeRenderer<ConstCodeSnippet, PostCodeEntity>();

            ConstCodeSnippet snippet = new ConstCodeSnippet();

            foreach (var item in postcodeEntities)
            {
                ICodeFragment fragment = renderer.CreateCodeFragment(item, snippet);
            }
            
        }
    }
}