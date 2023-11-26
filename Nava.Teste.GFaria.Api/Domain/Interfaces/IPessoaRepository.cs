namespace Nava.Teste.GFaria.Api.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        IList<Pessoa> Get(Func<Pessoa, bool> where = null);
    }
}
