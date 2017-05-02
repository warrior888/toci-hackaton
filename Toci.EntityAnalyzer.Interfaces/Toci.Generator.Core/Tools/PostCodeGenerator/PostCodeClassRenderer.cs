using System.Collections.Generic;
using System.IO;
using Toci.Generator.Core.Interfaces.Entities;

namespace Toci.Generator.Core.PostCodeGenerator
{
    public class PostCodeClassRenderer<TSource> : IClassCode
    {
        public Dictionary<string, ICodeFragment> CodePieces { get; set; }
    }
}