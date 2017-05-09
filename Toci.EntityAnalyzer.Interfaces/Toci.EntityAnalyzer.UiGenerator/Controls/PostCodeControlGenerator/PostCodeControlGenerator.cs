using System.Collections.Generic;
using System.Windows.Controls;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls.PostCodeControlGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Custom.PostCodeUiGenerator;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Controls.PostCodeControlGenerator
{
    public class PostCodeControlGenerator<TPraseResult, TCodeBehindEntity> : ControlGenerator<TPraseResult, TCodeBehindEntity>, IPostCodeControlGenerator<TPraseResult, TCodeBehindEntity>
        where TPraseResult : IPostCodeEntity
        where TCodeBehindEntity : ICodeBehindEntity
    {
        protected override string GenerateSkeleton()
        {
            throw new System.NotImplementedException();
        }
        

        public override IControlEntity Generate(TPraseResult complexProperty, TCodeBehindEntity codeBehindEntity)
        {
            IPostCodeEntity postCodeEntity = new PostCodeEntity();
            postCodeEntity.PostCode = complexProperty.PostCode;

            TextBox tb = new TextBox()
            {
                Name = complexProperty.PostCode
            };





            return null;
        }
    }
}