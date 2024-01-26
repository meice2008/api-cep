
using Refit;

namespace ApiCep.Interfaces;

public interface IApiCep
{
    [Get("/ws/{cep}/json")]
    Task<Endereco> GetEnderecoAsync(string cep);
}