using CoinJar.Common.Enums;
using FluentValidation;

namespace CoinJar.API.Models
{
    public class AddCoinRequest
    {
        public string CurrencyCode { get; set; }
        public decimal AmountInCents { get; set; }
    }

    public class AddCoinRequestSchemaValidator : AbstractValidator<AddCoinRequest>
    {
        public AddCoinRequestSchemaValidator()
        {
            RuleFor(x => x.CurrencyCode)
                .NotNull()
                .IsEnumName(typeof(CurrencyCode), caseSensitive: false);
            RuleFor(x => x.AmountInCents).GreaterThan(0);
        }
    }

}
