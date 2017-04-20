using System;
using System.Collections.Generic;
using System.Linq;
using Toci.EntityAnalyzer.Entities;
using Toci.EntityAnalyzer.Interfaces.Entities;
using Toci.EntityAnalyzer.Interfaces.Parametrization;
using Toci.EntityAnalyzer.Interfaces.Tools;

namespace Toci.EntityAnalyzer.Tools
{
    public class CtParser : ICtParser
    {
        public const int TableNamePosition = 2;
        public const int ColumnNamePosition = 0;

        public virtual List<ICtParsed> ParseCt(string allCt)
        {
            List<ICtParsed> result = new List<ICtParsed>();

            string[] separated =  allCt.Split(new[] {CtConsts.CtDelimiter}, StringSplitOptions.None);

            foreach (var ctElement in separated)
            {
                ICtParsed parsed = new CtParsed();
                var tableName = GetTableName(ctElement);

                if (!string.IsNullOrEmpty(tableName))
                {
                    parsed.TableName = tableName;
                    parsed.ColumnsWithDetails = GetTableColumns(ctElement);
                    parsed.Columns = new List<string>();

                    foreach (var columnWithDetails in parsed.ColumnsWithDetails)
                    {
                        parsed.Columns.Add(columnWithDetails.Split(new [] { CtConsts.CtSpaceDelimiter }, StringSplitOptions.None)[ColumnNamePosition]);
                    }

                    result.Add(parsed);
                }
            }

            return result;
        }

        protected virtual string GetTableName(string ctElement)
        {
            if (ctElement.IndexOf(CtConsts.Create) > -1 && ctElement.IndexOf(CtConsts.Table) > -1)
            {
                return ctElement.Substring(ctElement.IndexOf(CtConsts.Create), ctElement.IndexOf(CtConsts.CtOpenBracket) ).Split(new[] { CtConsts.CtSpaceDelimiter }, StringSplitOptions.None)[TableNamePosition].Trim();
            }

            return string.Empty;
        }

        protected virtual List<string> GetTableColumns(string ctElement)
        {
            string[] columns = ctElement.Substring(ctElement.IndexOf(CtConsts.CtOpenBracket) + 1, ctElement.LastIndexOf(CtConsts.CtCloseBracket) - ctElement.IndexOf(CtConsts.CtOpenBracket) - 1).Split(new[] { CtConsts.RowsDelimiter }, StringSplitOptions.None);
            List<string> result = new List<string>();

            foreach (var column in columns)
            {
                if (!string.IsNullOrEmpty(column.Trim()))
                {
                    result.Add(column.Trim());
                }
            }

            return result;
        }
    }
}