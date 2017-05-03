using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.Tools;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.Parser
{
    [TestClass]
    public class EntityAnalyzerParserTest
    {
        [TestMethod]
        public void CtParsingTest()
        {
            ICtParser parser = new CtParser();

            StreamReader rd = new StreamReader(@"..\..\..\..\Toci.EntityAnalyzer.Interfaces\Toci.EntityAnalyzer.Interfaces\Data\exampleCreateTable.txt");

            string allCt = rd.ReadToEnd();

            List<ICtParsed> parsed = parser.ParseCt(allCt);
        }
    }
}