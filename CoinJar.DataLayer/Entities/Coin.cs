namespace CoinJar.DataLayer.Entities
{
    public abstract class Coin: ICoin
    {
        public abstract decimal Amount { get; }
        public abstract decimal Volume { get; }
    }
}
