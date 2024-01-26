using ApiCep.Interfaces;
using ApiCep.Services;
using Microsoft.AspNetCore.Mvc;


namespace ApiCep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;
        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        // GET: api/<EnderecoController>
        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return _enderecoService.GetAll();
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EnderecoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
