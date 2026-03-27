using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CinemaController : ControllerBase
{

    private FilmeContext _context;
    private IMapper _mapper;

    public CinemaController(FilmeContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    [HttpPost]
    public IActionResult CreateCinema([FromBody] CreateCinemaDto cinemaDto)
    {
        var cinema = _mapper.Map<Cinema>(cinemaDto);
        _context.Cinema.Add(cinema);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetCinemaById), new { id = cinema.Id }, cinema);
    }

    [HttpGet]
    public IEnumerable<ReadCinemaDto> GetAllCinemas([FromQuery] int? enderecoId = null)
    {
        if (enderecoId == null)
        {
            return _mapper.Map<IEnumerable<ReadCinemaDto>>(_context.Cinema.ToList()); 
        }

        return _mapper.Map<IEnumerable<ReadCinemaDto>>
        (_context.Cinema
            .FromSqlRaw($"SELECT * FROM Cinema c WHERE c.EnderecoId = {enderecoId}").ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetCinemaById(int id)
    {
        var cinema = _context.Cinema.FirstOrDefault(c => c.Id == id);
        if (cinema == null) return NotFound();
        var CinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
        
        return Ok(CinemaDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
    {
        var cinema = _context.Cinema.FirstOrDefault(c => c.Id == id);
        if (cinema is null) return NotFound();

        _mapper.Map(cinemaDto, cinema);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCinema(int id)
    {
        var cinema = _context.Cinema.FirstOrDefault(c => c.Id == id);
        if (cinema is null) return NotFound();
        
        _context.Cinema.Remove(cinema);
        _context.SaveChanges();
        return NoContent();
    }
}