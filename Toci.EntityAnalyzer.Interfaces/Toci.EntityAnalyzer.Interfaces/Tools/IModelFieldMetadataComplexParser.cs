using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface IModelFieldMetadataComplexParser
    {
        Dictionary<string, string> GetMetadataForTable(string textToParse);

        Dictionary<string, object> GetMetadataForColumn(string textToParse);

        IModelFieldMetadata GetMetadataForField();
    }
}