using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface IClassCode
    {
        List<string> Consts { get; set; }
        List<string> Fields { get; set; }
        List<string> Properties { get; set; }
        List<string> Methods { get; set; }
    }
}