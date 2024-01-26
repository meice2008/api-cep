using ApiCep.Data;
using ApiCep.Interfaces;

namespace ApiCep.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly ApplicationDbContext _context;

        public EnderecoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Endereco> GetAll()
        {
            return _context.Enderecos.ToList();
        }

        public void Post(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }
    }
}
