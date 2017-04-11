using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.CodeBehind
{
    public abstract class CodeBehindGenerator : ICodeBehindGenerator
    {
        public ICodeBehindEntity Generate(IControlEntity controlEntity, IComplexProperty sCEntity)
        {
            throw new System.NotImplementedException();
        }

        protected abstract string GenerateSkeleton();
    }
}