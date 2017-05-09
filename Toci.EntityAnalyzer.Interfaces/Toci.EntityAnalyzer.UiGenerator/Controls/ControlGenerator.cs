using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls
{
    public abstract class ControlGenerator< TPraseResult, TCodeBehindEntity> : IControlGenerator<TPraseResult, TCodeBehindEntity>
        where TPraseResult : IParseResult
        where TCodeBehindEntity : ICodeBehindEntity
    {

        protected abstract string GenerateSkeleton();

        public virtual IControlEntity Generate(TPraseResult complexProperty, TCodeBehindEntity codeBehindEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}