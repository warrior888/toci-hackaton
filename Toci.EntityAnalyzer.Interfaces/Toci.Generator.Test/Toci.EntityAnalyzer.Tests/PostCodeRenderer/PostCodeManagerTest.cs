using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Generator.Core.Managers.PostCodeManager;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.PostCodeRenderer
{
    [TestClass]
    public class PostCodeManagerTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            PostCodeManager manager = new PostCodeManager(@"Z:\", "kody.csv");
            
            manager.Generate();

        }
    }
}
