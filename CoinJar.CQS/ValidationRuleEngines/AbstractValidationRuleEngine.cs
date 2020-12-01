using System.Collections.Generic;
using CoinJar.Common.Responses;
using CoinJar.CQS.ValidationRules;

namespace CoinJar.CQS.ValidationRuleEngines
{
    public abstract class AbstractValidationRuleEngine<T>: IValidationRuleEngine<T>
    {
        protected AbstractValidationRuleEngine()
        {
            ValidationRules = new List<IValidationRule<T>>();
        }

        public OperationResult Validate(T entity)
        {
            var operationResult = new OperationResult();
            foreach (var validationRule in ValidationRules)
            {
                var validationResult = validationRule.Validate(entity);

                if (validationResult.HasErrors)
                {
                    foreach (var keyValuePair in validationResult.GetErrorMessages())
                    {
                        operationResult.AddErrorMessage(keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
            return operationResult;
        }

        public IList<IValidationRule<T>> ValidationRules { get; set; }
    }
}
