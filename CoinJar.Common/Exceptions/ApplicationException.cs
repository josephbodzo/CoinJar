using System;

namespace CoinJar.Common.Exceptions
{
    public abstract class  ApplicationException: Exception
    {
        public abstract string Key { get;}
    }
}
