using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IColumnsParser
    {
        Dictionary<string, IModelColumnData> GetModelDataForColumns(ICtParsed parsedCt);
    }
}