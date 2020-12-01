using CoinJar.Common.Enums;

namespace CoinJar.Common.Exceptions
{
    public class CurrencyUnsupportedException: ApplicationException
    {
        public CurrencyUnsupportedException(CurrencyCode currency)
        {
            Message = $"{currency} is not currently supported";
        }

        public override string Key => "CurrencyCode";
        public override string Message { get; }
    }
}
