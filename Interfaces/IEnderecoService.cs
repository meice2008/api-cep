namespace ApiCep.Interfaces
{
    public interface IEnderecoService
    {
        List<Endereco> GetAll();
        void Post(Endereco endereco);
    }
}