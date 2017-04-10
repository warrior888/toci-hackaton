using System.Collections;
using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IEntityPropertyReader<in TEntity>
    {
        Dictionary<string, IEntityData> GetEntityFields(FieldKinds kinds, TEntity entity);

        Dictionary<string, Dictionary<string, IEntityData>> GetEntitesFields(FieldKinds kinds, IEnumerable<TEntity> entities);
    }
}