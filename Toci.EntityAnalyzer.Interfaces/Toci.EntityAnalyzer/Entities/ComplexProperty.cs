using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Entities
{
    public class ComplexProperty : IComplexProperty
    {
        public IEntityData Entity { get; set; }
        public IModelColumnData Model { get; set; }
        public IModelFieldMetadata MetaData { get; set; }
        public IParseResult ParseResult { get; set; }
    }
}