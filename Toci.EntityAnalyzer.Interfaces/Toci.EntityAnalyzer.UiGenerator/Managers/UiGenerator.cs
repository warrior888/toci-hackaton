using System.Collections.Generic;
using System.Text;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers;

namespace Toci.EntityAnalyzer.UiGenerator.Managers
{
    public class UiGenerator: IUiGenerator
    {
        public void GenerateUi(IControlGenerator controlGenerator, ICodeBehindGenerator codeBehindGenerator, IComplexEntity complexEntity)
        {
            var codeBehindEntities = new List<ICodeBehindEntity>();
            var controlEntities = new List<IControlEntity>();
            foreach (var complexProperty in complexEntity.ComplexProperties)
            {
                var codeBehindEntity = codeBehindGenerator.Generate(complexProperty.Value);
                codeBehindEntities.Add(codeBehindEntity);
                var controlEntity = controlGenerator.Generate(complexProperty.Value, codeBehindEntity);
                controlEntities.Add(controlEntity);
            }
            var stringBuilder = new StringBuilder();

        }
    }
}