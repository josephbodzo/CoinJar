using CoinJar.Common.Enums;
using CoinJar.Common.Exceptions;
using CoinJar.CQS.Factories.Implementation;

namespace CoinJar.CQS.Factories
{
    public  static class CoinFactoryProducer
    {
        public static ICoinFactory GetFactory(CurrencyCode currencyCode)
        {
            switch (currencyCode)
            {
                case CurrencyCode.USD:
                    return new UsdCoinFactory();
                default:
                    throw new CurrencyUnsupportedException(currencyCode);
            }
        }
    }
}
