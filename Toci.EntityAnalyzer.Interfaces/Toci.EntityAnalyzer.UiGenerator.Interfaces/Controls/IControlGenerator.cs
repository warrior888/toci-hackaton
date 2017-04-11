using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Controls
{
    public interface IControlGenerator
    {
        /// <summary>
        /// Generates control for given property based on its type, constraints etc
        /// </summary>
        /// <param name="complexProperty"></param>
        /// <returns></returns>
        IControlEntity GenerateControl(IComplexProperty complexProperty);
    }
}