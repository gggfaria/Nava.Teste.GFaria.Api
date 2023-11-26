using MediatR;
using Nava.Teste.GFaria.Api.Domain;
using Nava.Teste.GFaria.Api.DTOs;
using Nava.Teste.GFaria.Api.DTOs.Responses;

namespace Nava.Teste.GFaria.Api.Queries.Pessoas
{
    public record GetPessoasQuery(Func<Pessoa, bool> Where = null) : IRequest<BaseResponse<IList<GetPessoasResponse>>>;
    
}
