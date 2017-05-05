using System.Collections.Generic;
using System.IO;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.Generator.Core.Interfaces.Entities;

namespace Toci.Generator.Core.Tools
{
    public class CodeSnippet : ICodeSnippet
    {
        public string Snippet { get; set; }
        public void LoadSnippet(string path)
        {
            StreamReader sr = new StreamReader(path);

            Snippet = sr.ReadToEnd();
        }
    }
}