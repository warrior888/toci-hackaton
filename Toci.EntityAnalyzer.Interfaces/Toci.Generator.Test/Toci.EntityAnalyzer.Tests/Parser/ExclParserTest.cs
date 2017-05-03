using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.Tools;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.Parser
{
    [TestClass]
    public class ExclParserTest
    {
        [TestMethod]
        public void ExcelTest()
        {
            IExcelFIleParser<IExcelFileSource, IParseResult> Parser = new ExcelFileParser<IExcelFileSource, IParseResult>();

            Parser.Parse(new ExcelFileSource());

        }
    
    }
}