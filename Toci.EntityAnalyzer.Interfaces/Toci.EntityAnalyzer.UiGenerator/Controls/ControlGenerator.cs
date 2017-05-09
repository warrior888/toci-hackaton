using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls
{
    public abstract class ControlGenerator : IControlGenerator
    {

        protected abstract string GenerateSkeleton();
        public IControlEntity Generate(IParseResult complexProperty, ICodeBehindEntity codeBehindEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}