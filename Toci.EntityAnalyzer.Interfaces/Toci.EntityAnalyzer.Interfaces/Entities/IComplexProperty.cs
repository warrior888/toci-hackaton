namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains data about property taken from EF classes and SQL script
    /// </summary>
    public interface IComplexProperty
    {
        IEntityData Entity { get; set; }

        IModelColumnData Model { get; set; }

        IModelFieldMetadata MetaData { get; set; }
    }
}