using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(50, ErrorMessage = "Logradouro deve conter somente 50 caracteres")]
    public string Logradouro { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "O numero deve ser positivo")]
    public int Numero{ get; set; }
    
    public virtual Cinema Cinema{get;set;}
}