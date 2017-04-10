using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IMetadataParser
    {
        Dictionary<string, IModelFieldMetadata> GetMetadatasForCt(ICtParsed ct);
    }
}