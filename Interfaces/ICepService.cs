namespace ApiCep.Interfaces
{
    public interface ICepService
    {
        Task<Endereco> GetEnderecoDoCep_v1(string cep);
    }
}