using MediatR;
using UsoMeiatR.CQRS.Models;
using System.Collections.Generic;

namespace UsoMeiatR.CQRS.Queries
{
    public record SumasRealizadasQuery() : IRequest<List<ResultadoDto>>;

}
