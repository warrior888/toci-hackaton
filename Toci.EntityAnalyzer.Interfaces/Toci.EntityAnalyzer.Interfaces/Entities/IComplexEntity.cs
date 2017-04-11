using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Class definition, contains all properties as ComplexProperties
    /// </summary>
    public interface IComplexEntity
    {
        IList<IComplexProperty> ComplexProperties { get; set; }
    }
}