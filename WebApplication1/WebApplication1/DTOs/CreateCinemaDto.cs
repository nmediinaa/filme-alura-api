using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    [MaxLength(50,ErrorMessage = "O nome do cinema deve ter no maximo 50 caracteres!")]
    public string Nome { get; set; }
}