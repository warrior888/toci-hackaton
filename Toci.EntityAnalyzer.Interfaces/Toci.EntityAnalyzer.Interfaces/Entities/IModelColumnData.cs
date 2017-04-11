using System;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains data collected from SQL script
    /// </summary>
    public interface IModelColumnData
    {
        string Model { get; set; }

        string Name { get; set; }

        string Value { get; set; }

        Type Type { get; set; }

        string Constraints { get; set; }  

        KeyValuePair<string, string> ForeignKeyTableColumn { get; set; } 
    }
}