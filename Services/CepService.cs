namespace TodoApi.Services;
using Refit;
using TodoApi.Interfaces;
public class CepService : ICepService
{
    private readonly IConfiguration _configuration;
    public CepService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<Endereco> GetEnderecoDoCep_v1(string cep)
    {
        var baseUrl = _configuration.GetSection("ServiceUri:CepApiUrl").Value;

        var cepClient = RestService.For<IApiCep>(baseUrl);                        

        var result = cepClient.GetEnderecoAsync(cep);

        return result;
    }
}