using Microsoft.AspNetCore.Mvc;
using Refit;
using ApiCep.Interfaces;

namespace ApiCep.Controllers;

[ApiController]
[Route("[controller]")]
public class CepController : ControllerBase
{    
    private readonly ICepService _iCepService;

    public CepController (ICepService iCepService)  
    {        
        _iCepService = iCepService;
    }

    [HttpGet("service/{cep}")]
    public async Task<Endereco> GetServiceCep(string cep)
    {
        var retorno = await _iCepService.GetEnderecoDoCep_v1(cep);
        return retorno;

    }

    [HttpGet("web/{cep}")]
    public async Task<Endereco> GetWebCep(string cep)
    {
        try
        {
            var cepClient = RestService.For<IApiCep>("https://viacep.com.br");
            return await cepClient.GetEnderecoAsync(cep);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}