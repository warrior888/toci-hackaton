using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class ComplexParser<TResult> : IComplexParser
    {
        public virtual IComplexEntity ParseEntireCt(string tableCreates)
        {
            return null; // TODO
        }

        protected abstract TResult Parse(string tableCreates);

    }
}