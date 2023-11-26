using AutoMapper;
using Nava.Teste.GFaria.Api.Domain;
using Nava.Teste.GFaria.Api.DTOs.Responses;

namespace Nava.Teste.GFaria.Api.Profiles
{
    public class PessoasProfile : Profile
    {
        public PessoasProfile()
        {
            CreateMap<Pessoa, GetPessoasResponse>();
        }
    }

}
