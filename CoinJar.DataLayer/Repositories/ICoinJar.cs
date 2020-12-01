using CoinJar.DataLayer.Entities;

namespace CoinJar.DataLayer.Repositories
{
    public interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal GetTotalAmount();
        decimal GetTotalVolume();
        void Reset();
    }
}
