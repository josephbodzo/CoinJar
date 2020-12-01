using CoinJar.Common.Responses;
using CoinJar.DataLayer.Entities;
using CoinJar.DataLayer.Repositories;

namespace CoinJar.CQS.ValidationRules.Implementations
{
    public class MaxFluidOunceValidatorRule: IValidationRule<ICoin>
    {
        private readonly ICoinJar _coinJar;
        private readonly decimal _maxFluidOunces;

        public MaxFluidOunceValidatorRule(ICoinJar coinJar, decimal maxFluidOunces = 0.42M)
        {
            _coinJar = coinJar;
            _maxFluidOunces = maxFluidOunces;
        }

        public OperationResult Validate(ICoin currentCoin)
        {
            var operationResult = new OperationResult();
            var currentOunces = _coinJar.GetTotalVolume();
            if ((currentOunces + currentCoin.Volume) > _maxFluidOunces)
            {
                operationResult.AddErrorMessage("CoinJar",$"Coin Jar can only hold {_maxFluidOunces} fluid ounces. Current total fluid ounces: {currentOunces:N}, Coin Fluid Ounces: {currentCoin.Volume:N}");
            }

            return operationResult;
        }
    }
}
