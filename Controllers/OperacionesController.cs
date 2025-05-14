using Microsoft.AspNetCore.Mvc;
using MediatR;
using UsoMeiatR.CQRS.Commands;
using UsoMeiatR.CQRS.Queries;

namespace UsoMeiatR.CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacionesController : Controller
    {
        private readonly IMediator _mediator;

        public OperacionesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("sumar")]
        public async Task<IActionResult> Sumar([FromBody] SumarNumerosCommand comando)
        {
            var resultado = await _mediator.Send(comando);
            return Ok(new { resultado });
        }

        [HttpGet("historial")]
        public async Task<IActionResult> ObtenerHistorial()
        {
            var query = new SumasRealizadasQuery();
            var resultado = await _mediator.Send(query);
            return Ok(resultado);
        }
    }
}
