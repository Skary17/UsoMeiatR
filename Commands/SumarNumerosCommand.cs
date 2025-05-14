using MediatR;

namespace UsoMeiatR.CQRS.Commands
{
    public record SumarNumerosCommand(int A, int B) : IRequest<int>;
}
