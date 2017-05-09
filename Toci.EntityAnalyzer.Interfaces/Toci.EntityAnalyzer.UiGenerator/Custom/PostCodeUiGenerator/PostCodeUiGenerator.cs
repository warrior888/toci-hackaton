using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Custom.PostCodeUiGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Custom.PostCodeUiGenerator
{
    public class PostCodeUiGenerator<TOutput, TControlEntity, TCodeBehindGenerator> : Managers.UiGenerator<TOutput, TControlEntity, TCodeBehindGenerator>, 
        IPostCodeUiGenerator<TOutput,TControlEntity, TCodeBehindGenerator> 
        where TOutput : IPostCodeEntity 
        where TCodeBehindGenerator : ICodeBehindGenerator 
        where TControlEntity : IControlEntity
    {
    }
}