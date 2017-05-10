using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.UiGenerator.Data.PostCodeControlEntity;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls.PostCodeControlGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data.PostCodeControlEntity;

namespace Toci.EntityAnalyzer.UiGenerator.Controls.PostCodeControlGenerator
{
    public class PostCodeControlGenerator<TPraseResult, TCodeBehindEntity> : ControlGenerator<TPraseResult, TCodeBehindEntity>, IPostCodeControlGenerator<TPraseResult, TCodeBehindEntity>
        where TPraseResult : IPostCodeEntity
        where TCodeBehindEntity : ICodeBehindEntity
    {
        public IControlEntity ControlEntity { get; set; }

        public override IControlEntity Generate(TPraseResult complexProperty, TCodeBehindEntity codeBehindEntity)
        {
            ControlEntity = new PostCodeControlEntity(complexProperty.PostCode);

            return ControlEntity;
        }

        protected override string GenerateSkeleton()
        {
            throw new System.NotImplementedException();
        }
        
    }
}