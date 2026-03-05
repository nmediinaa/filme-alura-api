using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs;

public class CreateEnderecoDto
{
    [MaxLength(50, ErrorMessage = "Logradouro deve conter somente 50 caracteres")]
    public string Logradouro { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "O numero deve ser positivo")]
    public int Numero{ get; set; }
}