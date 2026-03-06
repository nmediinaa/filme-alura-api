using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) 
        : base(options)
    {
        
    }

    //Escrever sobre o DbSet
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinema { get; set; }

    public DbSet<Endereco> Endereco { get; set; }
}