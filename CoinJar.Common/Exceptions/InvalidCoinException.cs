using CoinJar.Common.Enums;

namespace CoinJar.Common.Exceptions
{
    public class InvalidCoinException: ApplicationException
    {
        public InvalidCoinException(decimal amount, CurrencyCode currencyCode)
        {
            Message = $"{amount} is not a valid coin amount for {currencyCode} currency.";
        }

        public override string Key => "Amount";
        public override string Message { get; }
    }
}
