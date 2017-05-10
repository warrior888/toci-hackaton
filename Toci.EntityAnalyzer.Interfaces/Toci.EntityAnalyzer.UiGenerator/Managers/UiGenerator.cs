using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers;

namespace Toci.EntityAnalyzer.UiGenerator.Managers
{
    public abstract class UiGenerator<TControlEntity, TCodeBehindGenerator> : IUiGenerator<TControlEntity, TCodeBehindGenerator> 
        where TControlEntity : IControlEntity 
        where TCodeBehindGenerator : ICodeBehindGenerator
    {
        protected Form Window;
        public abstract void GenerateUi(TControlEntity controlEntity, TCodeBehindGenerator codeBehindGenerator);
        public void Show()
        {
            Window.Show();
        }
    }
}