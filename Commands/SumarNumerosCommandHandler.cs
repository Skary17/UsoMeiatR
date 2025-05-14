using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace UsoMeiatR.CQRS.Commands
{
    public class SumarNumerosCommandHandler:IRequestHandler<SumarNumerosCommand, int>
    {
        public Task<int> Handle(SumarNumerosCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.A + request.B);
        }
    }
}
