using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nava.Teste.GFaria.Api.Queries.Pessoas;

namespace Nava.Teste.GFaria.Api.Controllers
{
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly ISender _mediator;

        public PessoasController(ISender mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new GetPessoasQuery());
            return StatusCode(result.StatusCode, result);
        }

    }
}
