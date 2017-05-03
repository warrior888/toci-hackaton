using System.Collections;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains data about the table schema, column names and table name
    /// </summary>
    public interface ICtParsed
    {
        string TableName { get; set; }

        List<string> Columns { get; set; }

        List<string> ColumnsWithDetails { get; set; }
    }
}