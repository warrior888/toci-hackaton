using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public abstract class FileParser<TSource, TParseResult, TLine> : IFIleParser<TSource, TParseResult>
        where TSource : IFileSource
        where TParseResult : IParseResult
    {
        protected virtual FileStream OpenFile(TSource source)
        {
            return new FileStream(source.FilePath+source.FileName, FileMode.Open);
        }
        
        public virtual IEnumerable<TParseResult> Parse(TSource source)
        {
            var file = OpenFile(source);

            return ParseResult(GetData(file));
        }

        protected virtual IEnumerable<TParseResult> ParseResult(IEnumerable<TLine> dataset)
        {
            List<TParseResult> resultList = new List<TParseResult>();

            foreach (var element in dataset)
            {
                resultList.Add(ParseLine(element));
            }

            return resultList;
        }


        protected abstract TParseResult ParseLine(TLine line);

        protected abstract IEnumerable<TLine> GetData(FileStream stream);
    }
}