using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls
{
    public class WpfControlGenerator : ControlGenerator
    {
        public override IControlEntity Generate(IComplexProperty complexProperty, ICodeBehindEntity codeBehindEntity)
        {
            throw new System.NotImplementedException();
        }

        protected override string GenerateSkeleton()
        {
            throw new System.NotImplementedException();
        }
    }
}