using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    public interface ICtModelMetadata
    {
        string FormTag { get; set; }

        FormOrientation Orientation { get; set; }
    }
}