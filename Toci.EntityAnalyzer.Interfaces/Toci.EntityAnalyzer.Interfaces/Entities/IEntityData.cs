using System;
using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains data collected from EF generated classes
    /// </summary>
    public interface IEntityData
    {
        string ClassName { get; set; } 

        string Name { get; set; }

        string Value { get; set; }

        Type FieldType {get; set; }
    }
}