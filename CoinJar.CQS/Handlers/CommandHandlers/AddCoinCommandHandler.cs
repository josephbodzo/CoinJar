using CoinJar.Common.Exceptions;
using CoinJar.Common.Responses;
using CoinJar.CQS.Factories;
using CoinJar.CQS.Messages;
using CoinJar.CQS.ValidationRuleEngines;
using CoinJar.DataLayer.Entities;
using CoinJar.DataLayer.Repositories;
using MediatR;

namespace CoinJar.CQS.Handlers.CommandHandlers
{
    public class AddCoinCommandHandler : RequestHandler<AddCoinCommand, OperationResult>
    {
        private readonly ICoinJar _db;
        private readonly IValidationRuleEngine<ICoin> _coinJarValidatorRulesEngine;

        public AddCoinCommandHandler(ICoinJar db, IValidationRuleEngine<ICoin> coinJarValidatorRulesEngine)
        {
            _db = db;
            _coinJarValidatorRulesEngine = coinJarValidatorRulesEngine;
        }

        protected override OperationResult Handle(AddCoinCommand command)
        {
            var result = new OperationResult();

            try
            {
                ICoinFactory coinFactory = CoinFactoryProducer.GetFactory(command.Currency);
                
                ICoin coin = coinFactory.GetCoin(command.Amount);
             
                OperationResult jarValidatorResult = _coinJarValidatorRulesEngine.Validate(coin);

                if (jarValidatorResult.HasErrors)
                {
                    result.AddErrorMessages(jarValidatorResult.GetErrorMessages());
                    return result;
                }

                _db.AddCoin(coin);
                return result;
            }
            catch (ApplicationException e)
            {
                result.AddErrorMessage(e.Key, e.Message);
            }
            
            return result;
        }
    }
}
