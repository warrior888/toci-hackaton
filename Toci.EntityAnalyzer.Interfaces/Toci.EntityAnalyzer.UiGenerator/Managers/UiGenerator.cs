using System;
using System.Collections.Generic;
using System.Text;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Managers;

namespace Toci.EntityAnalyzer.UiGenerator.Managers
{
    public abstract class UiGenerator<TOutput, TControlEntity, TCodeBehindGenerator> : IUiGenerator<TOutput, TControlEntity, TCodeBehindGenerator> 
        where TControlEntity : IControlEntity 
        where TCodeBehindGenerator : ICodeBehindGenerator
    {
        public IEnumerable<TOutput> GenerateUi(TControlEntity controlEntity, TCodeBehindGenerator codeBehindGenerator)
        {
            throw new NotImplementedException();
        }
    }
}