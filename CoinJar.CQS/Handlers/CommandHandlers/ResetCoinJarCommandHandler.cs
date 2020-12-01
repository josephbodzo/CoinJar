using CoinJar.CQS.Messages;
using CoinJar.DataLayer.Repositories;
using MediatR;

namespace CoinJar.CQS.Handlers.CommandHandlers
{
    public class ResetCoinJarCommandHandler : RequestHandler<ResetCoinJarCommand>
    {
        private readonly ICoinJar _db;

        public ResetCoinJarCommandHandler(ICoinJar db)
        {
            _db = db;
        }

        protected override void Handle(ResetCoinJarCommand coinJarCommand)
        {
            _db.Reset();
        }
    }
}
