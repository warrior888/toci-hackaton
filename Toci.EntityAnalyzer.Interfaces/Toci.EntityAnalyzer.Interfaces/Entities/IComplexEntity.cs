using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface IComplexEntity
    {
        Dictionary<string, IEntityData> Entities { get; set; }

        Dictionary<string, IModelColumnData> Models { get; set; }

        Dictionary<string, IModelFieldMetadata> MetaData { get; set; }
    }
}