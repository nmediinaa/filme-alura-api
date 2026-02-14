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
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = _id;
        _filmesList.Add(filme);
        _id++;
        return CreatedAtAction(nameof(GetFilmeById), new { id = filme.Id }, filme);
    }
    
    [HttpGet]
    public IEnumerable<Filme> GetAllFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _filmesList.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetFilmeById(int id)
    {
        var filme = _filmesList.FirstOrDefault(f => f.Id == id);
        if(filme == null) return NotFound();
        return Ok(filme);
    }
}