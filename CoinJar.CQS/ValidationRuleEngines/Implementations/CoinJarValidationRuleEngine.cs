using CoinJar.CQS.ValidationRules.Implementations;
using CoinJar.DataLayer.Entities;
using CoinJar.DataLayer.Repositories;

namespace CoinJar.CQS.ValidationRuleEngines.Implementations
{
    public class CoinJarValidationRuleEngine : AbstractValidationRuleEngine<ICoin>
    {
        public CoinJarValidationRuleEngine(ICoinJar coinJar)
        {
            ValidationRules.Add(new MaxFluidOunceValidatorRule(coinJar));
        }
    }
}
