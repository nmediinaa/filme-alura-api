using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private static List<Filme> _filmesList = new List<Filme>();
    private static int _id = 0;
    
    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = _id;
        _filmesList.Add(filme);
        Console.WriteLine(filme.Title);
        Console.WriteLine(filme.Diretor);
        _id++;
    }
    
    [HttpGet]
    public IEnumerable<Filme> GetAllFilmes()
    {
        return _filmesList;
    }

    [HttpGet("{id}")]
    public Filme? GetFilmeById(int id)
    {
        return _filmesList.FirstOrDefault(f => f.Id == id);
    }
}