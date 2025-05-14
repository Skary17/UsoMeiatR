using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UsoMeiatR.CQRS.Models;

namespace UsoMeiatR.CQRS.Queries
{
    public class LIstarSumasRealizadasCommandQueryHandler: IRequestHandler<SumasRealizadasQuery, List<ResultadoDto>>
    {
        public Task<List<ResultadoDto>> Handle(SumasRealizadasQuery request, CancellationToken cancellationToken)
        {
            // Simulando una lista de resultados
            var resultados = new List<ResultadoDto>
            {
                new (1, 5, 6),
                new (4, 5, 9),
                new (10, 20, 30)
            };

            return Task.FromResult(resultados);
        }
    }
    
}
