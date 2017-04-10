using System;
using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface IEntityData
    {
        string ClassName { get; set; }

        string Name { get; set; }

        FieldKinds FieldKind { get; set; }

        string Value { get; set; }

        Type FieldType {get; set; }
    }
}