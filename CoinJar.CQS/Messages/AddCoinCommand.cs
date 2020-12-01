using CoinJar.Common.Enums;
using CoinJar.Common.Responses;
using MediatR;

namespace CoinJar.CQS.Messages
{
    public class AddCoinCommand : IRequest<OperationResult>
    {
        public AddCoinCommand(CurrencyCode currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public CurrencyCode Currency { get; }
        public decimal Amount { get;}
    }
}
