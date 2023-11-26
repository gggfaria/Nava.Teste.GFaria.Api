using Nava.Teste.GFaria.Api.Domain;
using Nava.Teste.GFaria.Api.Domain.Interfaces;

namespace Nava.Teste.GFaria.Api.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {

        private static readonly List<Pessoa> Pessoas = new()
        {
            new("Pippin", "05303349098", DateTime.Now),
            new("Sam", "83781948099", DateTime.Now),
            new("Frodo", "71320282008", DateTime.Now),
            new("Merry", "07939491067", DateTime.Now)
        };

        public IList<Pessoa> Get(Func<Pessoa, bool> where = null)
        {
            if (where != null)
                return Pessoas.Where(where).ToList();
            return Pessoas;
        }
    }
}
