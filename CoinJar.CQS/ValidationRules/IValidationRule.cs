using CoinJar.Common.Responses;

namespace CoinJar.CQS.ValidationRules
{
    public interface IValidationRule<in T>
    {
        OperationResult Validate(T entity);
    }
}
