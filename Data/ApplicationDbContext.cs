using Microsoft.EntityFrameworkCore;

namespace ApiCep.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Endereco> Enderecos { get; set; } = null!;
}