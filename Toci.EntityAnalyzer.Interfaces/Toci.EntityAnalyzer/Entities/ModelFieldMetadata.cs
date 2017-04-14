using System;
using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Entities
{
    public class ModelFieldMetadata : IModelFieldMetadata
    {
        public string Tag { get; set; }

        public int ScreenId { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public Type Type { get; set; }

        public string RegularValidator { get; set; }

        public string CustomValidator { get; set; }

        public Dictionary<string, IEntityData> FillObligationDependentFields { get; set; }

        public Dictionary<string, IEntityData> LoadFieldsForFields { get; set; }
    }
}