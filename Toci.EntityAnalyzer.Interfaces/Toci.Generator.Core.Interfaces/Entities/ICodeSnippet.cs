using System.Diagnostics;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.Generator.Core.Interfaces.Entities
{
    public interface ICodeSnippet
    {
        string Snippet { get; set; }
        void LoadSnippet(string path);
    }
}