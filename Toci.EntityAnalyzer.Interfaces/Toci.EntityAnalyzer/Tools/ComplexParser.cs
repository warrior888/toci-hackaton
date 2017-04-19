using System;
using System.Linq;
using Toci.EntityAnalyzer.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class ComplexParser<TResult> : IComplexParser
    {
        public virtual IComplexEntity ParseEntireCt(string tableCreates)
        {
            IComplexEntity entity = new ComplexEntity();

            var baseType = typeof(ComplexParser<TResult>);
            var assembly = baseType.Assembly;

            var complexParsers = assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
            foreach (var parser in complexParsers)
            {
                if(parser != null)
                {
                    ComplexParser<object> instance = (ComplexParser<object>)Activator.CreateInstance(parser);
                    instance.Parse(tableCreates, entity);
                }
               
            }
            return entity; 
        }

        protected virtual string GetColumnName(string columnDdl)
        {
            return columnDdl.Split(new[] {" "}, StringSplitOptions.None)[0];
        }

        protected abstract void Parse(string tableCreates, IComplexEntity entity);

    }
}