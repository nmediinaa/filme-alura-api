using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private static List<Filme> _filmesList = new List<Filme>();
    
    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        _filmesList.Add(filme);
        Console.WriteLine(filme.Title);
        Console.WriteLine(filme.Diretor);
    }
    
    [HttpGet]
    public IEnumerable<Filme> GetFilmes()
    {
        return _filmesList;
    }
    
}