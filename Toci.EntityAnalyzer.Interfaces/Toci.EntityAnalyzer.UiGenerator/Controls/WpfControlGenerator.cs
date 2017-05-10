using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls
{
    public class WpfControlGenerator<TPraseResult, TCodeBehindEntity> : ControlGenerator<TPraseResult, TCodeBehindEntity> 
        where TPraseResult : IParseResult 
        where TCodeBehindEntity : ICodeBehindEntity
    {
        protected override string GenerateSkeleton()
        {
            throw new System.NotImplementedException();
        }
    }
}