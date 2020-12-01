using CoinJar.CQS.Messages;
using CoinJar.DataLayer.Repositories;
using MediatR;

namespace CoinJar.CQS.Handlers.QueryHandlers
{
    public class GetTotalAmountQueryHandler : RequestHandler<GetTotalAmountQuery, GetTotalAmountQueryResponse>
    {
        private readonly ICoinJar _db;

        public GetTotalAmountQueryHandler(ICoinJar db)
        {
            _db = db;
        }

        protected override GetTotalAmountQueryResponse Handle(GetTotalAmountQuery query)
        {
            return new GetTotalAmountQueryResponse { TotalAmount = _db.GetTotalAmount()};
        }
    }
}
