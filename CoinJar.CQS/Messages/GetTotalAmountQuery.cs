using MediatR;

namespace CoinJar.CQS.Messages
{
    public class GetTotalAmountQuery : IRequest<GetTotalAmountQueryResponse>
    {

    }
}
