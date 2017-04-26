using System.Collections.Generic;
using System.IO;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public class TextFileParser < TSource, TParseResult> : FileParser<TSource, TParseResult, string>, ITextFIleParser<TSource, TParseResult>
        where TSource : ITextFileSource
        where TParseResult : IParseResult
    {
        protected override TParseResult ParseLine(string line)
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerable<string> GetData(FileStream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}