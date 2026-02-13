using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "O Genero do filme é obrigatório")]
    public string Genero { get; set; }
    
    [Required]
    [Range(70, 600, ErrorMessage = "A duraçao do filme deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
    
    [Required(ErrorMessage = "O Diretor do filme é obrigatório")]
    public string Diretor { get; set; }
}