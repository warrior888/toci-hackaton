namespace Toci.EntityAnalyzer.Interfaces.Validation
{
    public interface ICustomValidator<TEntity, Tvr>
    {
        IValidationResult<Tvr> Validate(TEntity entity);
    }
}