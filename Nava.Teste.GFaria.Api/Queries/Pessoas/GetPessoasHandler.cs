using AutoMapper;
using MediatR;
using Nava.Teste.GFaria.Api.Domain.Interfaces;
using Nava.Teste.GFaria.Api.DTOs;
using Nava.Teste.GFaria.Api.DTOs.Responses;
using System.Net;

namespace Nava.Teste.GFaria.Api.Queries.Pessoas
{
    public class GetPessoasHandler : IRequestHandler<GetPessoasQuery, BaseResponse<IList<GetPessoasResponse>>>
    {
        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public GetPessoasHandler(IPessoaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<BaseResponse<IList<GetPessoasResponse>>> Handle(GetPessoasQuery request, CancellationToken cancellationToken)
        {
            var listPessoas = _repository.Get(request.Where);
            var response = _mapper.Map<List<GetPessoasResponse>>(listPessoas);

            if(response == null || response.Count == 0)
                return Task.FromResult(new BaseResponse<IList<GetPessoasResponse>>((int)HttpStatusCode.NoContent, response));

            return Task.FromResult(new BaseResponse<IList<GetPessoasResponse>>((int)HttpStatusCode.OK, response));
        }
    }
}
