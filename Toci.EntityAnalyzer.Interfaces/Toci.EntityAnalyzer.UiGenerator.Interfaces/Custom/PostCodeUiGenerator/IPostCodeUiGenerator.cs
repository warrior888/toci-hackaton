using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Custom.PostCodeUiGenerator
{
    public interface IPostCodeUiGenerator<out TOutput, in TControlEntity, in TCodeBehindGenerator> : IUiGenerator<TOutput, TControlEntity, TCodeBehindGenerator>
        where TOutput : IPostCodeEntity
        where TControlEntity : IControlEntity
        where TCodeBehindGenerator : ICodeBehindGenerator
    {

    }
}