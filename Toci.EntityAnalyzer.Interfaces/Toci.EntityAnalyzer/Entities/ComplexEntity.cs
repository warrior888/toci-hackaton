using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Entities
{
    public class ComplexEntity : IComplexEntity
    {
        public string Name { get; set; }
        public Dictionary<string, IComplexProperty> ComplexProperties { get; set; }
    }
}