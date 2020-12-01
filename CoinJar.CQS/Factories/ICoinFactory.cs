using CoinJar.DataLayer.Entities;

namespace CoinJar.CQS.Factories
{
    public interface ICoinFactory
    {
         ICoin GetCoin(decimal amount);
    }
}
