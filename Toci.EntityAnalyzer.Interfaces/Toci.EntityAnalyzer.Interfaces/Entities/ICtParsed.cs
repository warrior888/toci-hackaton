using System.Collections;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface ICtParsed
    {
        string TableName { get; set; }

        IList<string> Rows { get; set; }
    }
}