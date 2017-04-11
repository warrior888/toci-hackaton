using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.UiGenerator.Interfaces.Form
{
    public interface IFormGenerator
    {
        /// <summary>
        /// Method generates form skeleton based on controls number and orientation
        /// </summary>
        /// <param name="entity">entity for which we create form</param>
        /// <param name="modelData"></param>
        /// <returns></returns>
        string GenerateForm(IComplexEntity entity, ICtModelMetadata modelData);
    }
}