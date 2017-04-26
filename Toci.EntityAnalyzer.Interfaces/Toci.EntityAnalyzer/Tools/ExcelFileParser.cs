using System.Collections.Generic;
using System.Data;
using System.IO;
using Excel;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities.Parsing;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public class ExcelFileParser <TSource, TParseResult> : FileParser<TSource, TParseResult, DataRow>, IExcelFIleParser<TSource, TParseResult>
        where TSource : IExcelFileSource
        where TParseResult : IParseResult
    {
        public override IEnumerable<TParseResult> Parse(TSource source)
        {
            FileStream file = new FileStream(source.FilePath, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(file);
            
            DataSet result = excelReader.AsDataSet();

            foreach (var row in result.Tables[0].Rows)
            {
                
            }

            return null;
        }

        protected override TParseResult ParseLine(DataRow line)
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerable<DataRow> GetData(FileStream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}