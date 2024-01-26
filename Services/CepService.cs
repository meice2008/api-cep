namespace ApiCep.Services;
using Refit;
using ApiCep.Interfaces;
public class CepService : ICepService
{
    private readonly IConfiguration _configuration;
    private readonly IEnderecoService _enderecoService;
    public CepService(IConfiguration configuration, IEnderecoService enderecoService)
    {
        _configuration = configuration;
        _enderecoService = enderecoService;
    }

    public Task<Endereco> GetEnderecoDoCep_v1(string cep)
    {
        var baseUrl = _configuration.GetSection("ServiceUri:CepApiUrl").Value;

        var cepClient = RestService.For<IApiCep>(baseUrl);                        

        var result = cepClient.GetEnderecoAsync(cep);

        _enderecoService.Post(result.Result);


        return result;
    }
}