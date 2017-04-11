namespace Toci.EntityAnalyzer.Interfaces.Validation
{
    public interface IValidationResult<Tvr>
    {
        Tvr ValidationResults { get; set; }

        bool IsValid { get; set; }
    }
}