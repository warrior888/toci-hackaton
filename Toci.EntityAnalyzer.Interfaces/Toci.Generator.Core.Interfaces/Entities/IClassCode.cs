using System.Collections.Generic;

namespace Toci.Generator.Core.Interfaces.Entities
{
    public interface IClassCode
    {
        Dictionary<string, ICodeFragment> CodePieces { get; set; }
    }
}