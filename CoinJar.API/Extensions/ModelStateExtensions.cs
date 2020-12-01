using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoinJar.API.Extensions
{
    public static class ModelStateExtensions
    {
        public static void AddErrors(this ModelStateDictionary modelState, IDictionary<string, string> errors)
        {
            foreach (var (key, value) in errors)
            {
                modelState.AddModelError(key, value);
            }
        }
    }
}
