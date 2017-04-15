using System;
using System.Linq;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class ComplexParser<TResult> : IComplexParser
    {
        public virtual IComplexEntity ParseEntireCt(string tableCreates)
        {
            var baseType = typeof(ComplexParser<TResult>);
            var assembly = baseType.Assembly;

            var complexParsers = assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
            foreach (var parser in complexParsers)
            {
                if(parser != null)
                {
                    dynamic instance = Activator.CreateInstance(parser);
                    var method = instance.GetMethod("Parse");
                    if (method != null)
                    {
                        method.Invoke(instance, tableCreates);
                    }
                }
               
            }
            return null; // TODO          
        }

        protected abstract TResult Parse(string tableCreates);

    }
}