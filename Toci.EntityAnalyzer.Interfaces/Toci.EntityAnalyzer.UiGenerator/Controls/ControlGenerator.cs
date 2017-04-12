using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls
{
    public abstract class ControlGenerator : IControlGenerator
    {
        public abstract IControlEntity Generate(IComplexProperty complexProperty, ICodeBehindEntity codeBehindEntity);

        protected abstract string GenerateSkeleton();

    }
}