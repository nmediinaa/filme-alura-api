using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class ReadFilmeDto
{
    public int Id  { get; set; }
    public string Title { get; set; }
    
    public string Genero { get; set; }
    
    public int Duracao { get; set; }
    
    public string Diretor { get; set; }

    public DateTime DataConsulta { get; set; } = DateTime.Now;

    public ICollection<ReadSessaoDto> sessoes { get; set; }   
}