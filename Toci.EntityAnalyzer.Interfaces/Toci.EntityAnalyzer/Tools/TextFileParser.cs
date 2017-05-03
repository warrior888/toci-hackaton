using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class TextFileParser<TSource, TParseResult> : FileParser<TSource, TParseResult, string>, ITextFIleParser<TSource, TParseResult>
        where TSource : ITextFileSource
        where TParseResult : IParseResult
    {
        private const string Delimiter = "\n";
        
        protected override IEnumerable<string> GetData(FileStream stream)
        {
            StreamReader sr = new StreamReader(stream);

            return sr.ReadToEnd().Split(new[] {Delimiter}, StringSplitOptions.None).ToList();
            
        }
    }
}