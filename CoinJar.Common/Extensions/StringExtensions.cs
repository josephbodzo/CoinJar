using System;
using CoinJar.Common.Enums;

namespace CoinJar.Common.Extensions
{
    public static class StringExtensions
    {
        public static CurrencyCode ToCurrencyCode(this string str)
        {
           return  (CurrencyCode)Enum.Parse(typeof(CurrencyCode), str, true);
        }
    }
}
