
using Refit;

namespace TodoApi.Interfaces;

public interface IApiCep
{
    [Get("/ws/{cep}/json")]
    Task<Endereco> GetEnderecoAsync(string cep);
}