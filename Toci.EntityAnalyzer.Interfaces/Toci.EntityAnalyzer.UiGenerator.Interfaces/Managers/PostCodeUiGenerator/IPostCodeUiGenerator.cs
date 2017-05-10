using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers.PostCodeUiGenerator
{
    public interface IPostCodeUiGenerator<in TControlEntity, in TCodeBehindGenerator> : IUiGenerator<TControlEntity, TCodeBehindGenerator> 
        where TControlEntity : IControlEntity 
        where TCodeBehindGenerator : ICodeBehindGenerator
    {
        
    }
}