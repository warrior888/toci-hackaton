using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.Generator.Core.Interfaces.Managers.PostCodeManager
{
    public interface IPostCodeManager
    {
        IEnumerable<IPostCodeEntity> PostCodeEntitys { get; set; }
    }
}