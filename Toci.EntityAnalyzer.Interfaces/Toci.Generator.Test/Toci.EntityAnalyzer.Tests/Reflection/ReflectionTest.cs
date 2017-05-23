using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.Generator.Test.Toci.EntityAnalyzer.Tests.Reflection
{
    [TestClass]
    public class ReflectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var results = from type in Toci.EntityAnalyzer.
            //              where typeof(I).IsAssignableFrom(type)
            //              select type;

            IEnumerable<Type> mytypes =
            System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IParseResult)));
            

        }
    }
}
