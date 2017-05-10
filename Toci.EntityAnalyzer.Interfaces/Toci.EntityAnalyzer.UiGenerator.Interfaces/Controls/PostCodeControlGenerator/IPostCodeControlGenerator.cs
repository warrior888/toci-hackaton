using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data.PostCodeControlEntity;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls.PostCodeControlGenerator
{
    public interface IPostCodeControlGenerator<in TPraseResult, in TCodeBehindEntity> : IControlGenerator<TPraseResult, TCodeBehindEntity>
        where TPraseResult : IPostCodeEntity
        where TCodeBehindEntity : ICodeBehindEntity
    {
        IControlEntity ControlEntity { get; set; }
    }
}