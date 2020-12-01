using CoinJar.Common.Responses;

namespace CoinJar.CQS.ValidationRuleEngines
{
    public interface IValidationRuleEngine<in T>
    {
        OperationResult Validate(T entity);
    }
}
