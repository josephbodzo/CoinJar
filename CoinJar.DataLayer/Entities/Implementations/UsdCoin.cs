namespace CoinJar.DataLayer.Entities.Implementations
{
    public abstract class UsdCoin: Coin
    {
    }

    public class UsdPenny : UsdCoin
    {
        public override decimal Amount => 1;
        public override decimal Volume => 0.0122M;
    }

    public class UsdNickel : UsdCoin
    {
        public override decimal Amount => 5;
        public override decimal Volume => 0.0243M;
    }

    public class UsdDime : UsdCoin
    {
        public override decimal Amount => 25;
        public override decimal Volume => 0.0270M;
    }

    public class UsdHalfDollar: UsdCoin
    {
        public override decimal Amount => 50;
        public override decimal Volume => 0.0534M;
    }

    public class UsdDollar : UsdCoin
    {
        public override decimal Amount => 100;
        public override decimal Volume => 0.0800M;
    }
}
