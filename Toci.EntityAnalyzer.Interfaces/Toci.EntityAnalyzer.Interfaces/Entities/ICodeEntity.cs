using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Specify all the control features in code
    /// </summary>
    public interface ICodeEntity
    {
        IList<string> Properties { get; set; } 
        IList<string> Handlers { get; set; }
    }
}