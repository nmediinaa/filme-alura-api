using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : Controller
{
    private FilmeContext _context;
    private IMapper _mapper;

    public EnderecoController(FilmeContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    [HttpPost]
    public IActionResult CreteEndereco([FromBody] CreateEnderecoDto enderecoDto)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDto);
        _context.Endereco.Add(endereco);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetEnderecosById), new { id = endereco.Id }, endereco);
    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto>GetAllEnderecos([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        var enderecos = _mapper.Map<List<ReadEnderecoDto>>(
            _context.Endereco.Skip(skip).Take(take));
        return enderecos;
    }

    [HttpGet("{id}")]
    public IActionResult GetEnderecosById([FromRoute] int id)
    {
        var endereco = _context.Endereco.FirstOrDefault(e => e.Id == id);
        if (endereco == null) return NotFound();
        return Ok( _mapper.Map<ReadEnderecoDto>(endereco));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEnderecoById(int id, [FromBody] UpdateEnderecoDto enderecoDto)
    {
        var endereco = _context.Endereco.FirstOrDefault(e => e.Id == id);
        if (endereco == null) return NotFound();

        _mapper.Map(enderecoDto, endereco);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEndereco(int id)
    {
        var endereco = _context.Endereco.FirstOrDefault(e => e.Id == id);
        if(endereco == null) return NotFound();
        
        _context.Endereco.Remove(endereco);
        _context.SaveChanges();
        return NoContent();
    }
}