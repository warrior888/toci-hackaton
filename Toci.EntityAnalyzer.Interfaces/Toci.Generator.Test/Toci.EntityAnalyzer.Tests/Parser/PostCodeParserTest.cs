using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Tools.PostCodeParser;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.Parser
{
    [TestClass]
    public class PostCodeParserTest
    {
        [TestMethod]
        public void PostCode()
        {
            PostCodeTextFileParser<TextFileSource, PostCodeEntity> test = new PostCodeTextFileParser<TextFileSource, PostCodeEntity>();
            ITextFileSource source = new TextFileSource{FilePath = @"Z:\", FileName = "kody.csv"};
            test.Parse((TextFileSource)source);
        }

    }
}