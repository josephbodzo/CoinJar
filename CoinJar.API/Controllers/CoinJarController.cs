using System.Threading.Tasks;
using CoinJar.API.Extensions;
using CoinJar.API.Models;
using CoinJar.Common.Extensions;
using CoinJar.CQS.Messages;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoinJar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinJarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoinJarController( IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetTotalAmount")]
        public async Task<decimal> GetTotalAmount()
        {
            var response = await _mediator.Send(new GetTotalAmountQuery());
            return response.TotalAmount;
        }

        [HttpPut]
        [Route("ResetJar")]
        public Task ResetJar()
        {
            return _mediator.Send(new ResetCoinJarCommand());
        }

        [HttpPost]
        [Route("AddCoin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddCoin(AddCoinRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var response = await _mediator.Send(new AddCoinCommand(request.CurrencyCode.ToCurrencyCode(), request.AmountInCents));

            if (response.HasErrors)
            {
                ModelState.AddErrors(response.GetErrorMessages());
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
