using CoinJar.Common.Enums;
using CoinJar.Common.Exceptions;
using CoinJar.DataLayer.Entities;
using CoinJar.DataLayer.Entities.Implementations;

namespace CoinJar.CQS.Factories.Implementation
{
    public class UsdCoinFactory: ICoinFactory
    {
        public ICoin GetCoin(decimal amount)
        {
            switch (amount)
            {
                case 1:
                    return new UsdPenny();
                case 5:
                    return new UsdNickel();
                case 25:
                    return new UsdDime();
                case 50:
                    return new UsdHalfDollar();
                case 100:
                    return new UsdDollar();
                default:
                    throw new InvalidCoinException(amount, CurrencyCode.USD);
            }
        }
    }
}
