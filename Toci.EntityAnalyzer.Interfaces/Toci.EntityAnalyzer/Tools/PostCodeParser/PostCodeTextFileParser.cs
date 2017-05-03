using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.EntityAnalyzer.Entities.Parsing.PostCodeParser;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;

namespace Toci.EntityAnalyzer.Tools.PostCodeParser
{
    public class PostCodeTextFileParser<TSource, TParseResult> : TextFileParser<TSource, TParseResult>
        where TSource : ITextFileSource
        where TParseResult : IPostCodeEntity
    {
        private const string Delimiter = ";";

        protected override TParseResult ParseLine(string line)
        {

        IPostCodeEntity entity = new PostCodeEntity();

            var splitLine = line.Split(new[] {Delimiter}, StringSplitOptions.None);
            if (splitLine[0].Length > 0)
            {
                entity.PostCode = splitLine[0];
                entity.Address = splitLine[1];
                entity.Place = splitLine[2];
                entity.Province = splitLine[3];
                entity.County = splitLine[4].Trim();
            }

            return (TParseResult)entity;
        }
    }
}