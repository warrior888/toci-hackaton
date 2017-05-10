using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls
{
    public interface IControlGenerator<in TPraseResult, in TCodeBehindEntity>
        where TPraseResult : IParseResult
        where TCodeBehindEntity : ICodeBehindEntity
    {
        /// <summary>
        /// Generates control for given property with satisfying given code behind for it
        /// </summary>
        /// <param name="complexProperty"></param>
        /// <param name="codeBehindEntity"></param>
        /// <returns></returns>
        IControlEntity Generate(TPraseResult complexProperty, TCodeBehindEntity codeBehindEntity);
    }
}