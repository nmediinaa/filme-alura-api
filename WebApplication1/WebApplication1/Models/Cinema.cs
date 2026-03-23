using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace WebApplication1.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    [MaxLength(50,ErrorMessage = "O nome do cinema deve ter no maximo 50 caracteres!")]
    public string Nome { get; set; }

    public int EnderecoId { get; set; }
    
    public virtual Endereco Endereco { get; set; }

    public virtual ICollection<Sessao> sessoes {get; set; }

}