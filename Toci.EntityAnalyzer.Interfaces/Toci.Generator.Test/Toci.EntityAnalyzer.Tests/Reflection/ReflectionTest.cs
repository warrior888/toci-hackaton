using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
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


            PostCodeEntity look = new PostCodeEntity();

            
            var method = typeof(PostCodeEntity).GetMethod("RemoveThis");
            //method.MakeGenericMethod()

            var types = Assembly.GetAssembly(typeof(PostCodeEntity)).GetTypes().Where(m => typeof(IParseResult).IsAssignableFrom(m));

            foreach (Type type in types)
            {
                MethodInfo showThisMethod = look.GetType().GetMethod("RemoveThis", BindingFlags.Instance | BindingFlags.NonPublic);
                var tujesttoczegonamtrzeba = showThisMethod.MakeGenericMethod(type, type);

                tujesttoczegonamtrzeba.Invoke(look, new object [] { 8, "Erley" });

                IParseResult test234 = (IParseResult)Activator.CreateInstance(type);

                test234.RemoveThis();

                List<string> fff = new List<string>();

                //fff.AsParallel().WithDegreeOfParallelism(8).ForAll();
                
                //look.ShowThis <type> ();
            }

            var test = Assembly.Load("Toci.EntityAnalyzer").GetTypes().Where(m => typeof(IParseResult).IsAssignableFrom(m));

            //var erleytest = Assembly.LoadFile()

            IEnumerable<Type> mytypes =
            System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IParseResult)));
            

        }
    }
}
