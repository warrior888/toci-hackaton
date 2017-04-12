using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind
{
    public interface ICodeBehindGenerator
    {
        /// <summary>
        /// Generate Code behind for given property based on constaints, type etc
        /// </summary>
        /// <param name="complexProperty"></param>
        /// <returns></returns>
        ICodeBehindEntity Generate(IComplexProperty complexProperty);


    }
}