using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.CodeBehind
{
    public interface ICodeBehindGenerator
    {
        /// <summary>
        /// Generate Code behind for given property ans based on already generated control
        /// </summary>
        /// <param name="controlEntity"></param>
        /// <param name="complexProperty"></param>
        /// <returns></returns>
        ICodeBehindEntity Generate(IControlEntity controlEntity, IComplexProperty complexProperty);
    }
}