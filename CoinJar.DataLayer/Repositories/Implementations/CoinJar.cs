using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using CoinJar.DataLayer.Entities;

namespace CoinJar.DataLayer.Repositories.Implementations
{
    public class CoinJar: ICoinJar
    {
        private ConcurrentBag<ICoin> _coins = new ConcurrentBag<ICoin>();

        public void AddCoin(ICoin coin)
        {
            _coins.Add(coin);
        }

        public decimal GetTotalAmount()
        {
           return _coins.Select(c=> c.Amount).Sum();
        }

        public decimal GetTotalVolume()
        {
            return _coins.Select(c => c.Volume).Sum();
        }

        public void Reset()
        {
            //clear bag in a thread-safe way
            var newBag = new ConcurrentBag<ICoin>();
            Interlocked.Exchange(ref _coins, newBag);
        }
    }
}
