using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) 
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Sessao>()
            .HasKey(sessao => new {sessao.FilmeId, sessao.CinemaId});
        
        builder.Entity<Sessao>()
            .HasOne(sessao => sessao.Cinema)
            .WithMany(cinema => cinema.sessoes )
            .HasForeignKey(sessao => sessao.CinemaId);
        
        builder.Entity<Sessao>()
            .HasOne(sessao => sessao.Filme)
            .WithMany(filme => filme.Sessoes)
            .HasForeignKey(sessao => sessao.FilmeId);
    }

    //Escrever sobre o DbSet
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinema { get; set; }

    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}