using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface IComplexEntity
    {
        Dictionary<string, IEntityData> Entities { get; set; }

        Dictionary<string, IModelData> Models { get; set; }

        Dictionary<string, IModelFieldMetadata> MetaData { get; set; }
    }
}