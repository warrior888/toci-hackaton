using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers
{
    public interface IUiGenerator<in TControlEntity,in TCodeBehindGenerator>
        where TControlEntity : IControlEntity
        where TCodeBehindGenerator : ICodeBehindGenerator
    {
        /// <summary>
        /// collect data from generators in right order and invoke save method(abstract method) so we can change saving medium
        /// </summary>
        /// <param name = "controlGenerator" ></ param >
        /// < param name="codeBehindGenerator"></param>
        /// <param name = "complexEntity" ></ param >
        void GenerateUi(TControlEntity controlEntity, TCodeBehindGenerator codeBehindGenerator);

        void Show();
    }
}