using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains metadata about table
    /// </summary>
    public interface ICtModelMetadata
    {
        string FormTag { get; set; }

        FormOrientation Orientation { get; set; }
    }
}