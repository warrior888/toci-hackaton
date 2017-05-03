using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Entities
{
    public class CtParsed : ICtParsed
    {
        public string TableName { get; set; }
        public List<string> Columns { get; set; }
        public List<string> ColumnsWithDetails { get; set; }
    }
}