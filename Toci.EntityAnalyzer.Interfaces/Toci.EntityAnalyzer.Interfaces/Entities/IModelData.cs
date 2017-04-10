using System;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface IModelData
    {
        string Model { get; set; }

        string Name { get; set; }

        string Value { get; set; }

        Type Type { get; set; }

        string Constraints { get; set; }

        string ForeignKeyTable { get; set; }
    }
}