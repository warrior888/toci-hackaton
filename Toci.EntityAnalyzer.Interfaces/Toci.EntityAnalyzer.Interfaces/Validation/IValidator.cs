namespace Toci.EntityAnalyzer.Interfaces.Validation
{
    public interface IValidator<TEntity, Tvr>
    {
        IValidationResult<Tvr> Validate(TEntity entity);
    }
}