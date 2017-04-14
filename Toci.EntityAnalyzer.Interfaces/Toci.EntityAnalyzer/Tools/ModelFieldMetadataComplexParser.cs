using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text.RegularExpressions;
using Toci.EntityAnalyzer.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Parametrization;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    // TODO Find out what exactly needs to be returned
    public class ModelFieldMetadataComplexParser : IModelFieldMetadataComplexParser
    {
        public Dictionary<string, string> GetMetadataForTable(string textToParse)
        {
            return new Dictionary<string, string>(); // TODO
        }

        public Dictionary<string, object> GetMetadataForColumn(string textToParse)
        {
            // This logic extracts and pairs metadata from the single line
            // It doesn't separate data for Fodf and Lfff, just stores them as a string chain
            // TODO Check if it's Fodf or Lfff and execute suitable method
            string pattern = @"(\w+):(\w|#|\s)+"; // need info whether to keep it as it is or use CtConsts
            Regex regex = new Regex(pattern);

            Dictionary<string, object> metadata = new Dictionary<string, object>();
            foreach (Match match in regex.Matches(textToParse))
            {
                string[] KeyValue = Regex.Split(match.Value, CtConsts.MetadataDelimiter);
                metadata.Add(KeyValue[0], KeyValue[1]);
            }

            return metadata;
        }

        public IModelFieldMetadata GetMetadataForField()
        {
            IModelFieldMetadata modelFieldMetadata = new ModelFieldMetadata();
            return modelFieldMetadata; // TODO map results with modelFieldMetadata
        }
    }
}