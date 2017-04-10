using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.Interfaces.Parametrization
{
    public static class CtConsts
    {
        public const string Create = "create";
        public const string Table = "table";
        public const string References = "references";
        public const string ColumnDelimiter = ",";
        public const string CtDelimiter = ";";
        public const string CtOpenBracket = "(";
        public const string CtCloseBracket = ")";
        public const string MetadataOpenBracket = "[";
        public const string MetadataCloseBracket = "]";
        public const string MetadataDelimiter = ":";
        public const string MetadataSeparationDelimiter = "|";
        public const string RowsDelimiter = "/";
        public const string Comment = "--";

        public const string FodfLfffDelimiter = "#";

        public const string ScreenId = "ScreenId";
        public const string Tag = "Tag";
        public const string Orientation = "Orientation";
        public const string RegularValidator = "RValidator";
        public const string CustomValidator = "CValidator";
        public const string FillObligationDependentFields = "Fodf";
        public const string LoadFieldsForFields = "Lfff";

        public static Dictionary<string, Type> TypesMapping = new Dictionary<string, Type>
        {
            
        };
    }
}