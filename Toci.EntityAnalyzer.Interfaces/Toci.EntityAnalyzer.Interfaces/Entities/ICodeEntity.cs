using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Specify all the control features in code
    /// </summary>
    public interface ICodeEntity
    {
        Dictionary<string,string> Consts { get; set; } 
        Dictionary<string,string> Properties { get; set; } 
        Dictionary<string,string> Fields { get; set; } 
        Dictionary<string,string> Methods { get; set; }
    }
}