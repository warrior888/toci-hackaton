using System.Collections.Generic;
using System.Windows.Forms;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data.PostCodeControlEntity;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers.PostCodeUiGenerator;

namespace Toci.EntityAnalyzer.UiGenerator.Managers.PostCodeUiGenerator
{
    public class PostCodeUiGenerator<TControlEntity, TCodeBehindGenerator> : UiGenerator<TControlEntity, TCodeBehindGenerator>, IPostCodeUiGenerator<TControlEntity, TCodeBehindGenerator>
        where TControlEntity : IPostCodeControlEntity 
        where TCodeBehindGenerator : ICodeBehindGenerator
    {
        private int i = 20;
        public PostCodeUiGenerator()
        {
            Window = new Form();
        }
        public override void GenerateUi(TControlEntity controlEntity, TCodeBehindGenerator codeBehindGenerator)
        {
            if (i < 300)
            {
                Window.Controls.Add(AllocateTextBox(controlEntity));
            }
        }

        protected TextBox AllocateTextBox(TControlEntity controlEntity)
        {
            controlEntity.TextBox.Size = new System.Drawing.Size(70,20);
            controlEntity.TextBox.Location = new System.Drawing.Point(20, i+=20);

            return controlEntity.TextBox;
        }

    }
}