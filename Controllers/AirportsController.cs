using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public AirportsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Airport> entities = _context.Airports.Include(c => c.City).AsNoTracking();
            IEnumerable<AirportToListDto> dtos = _mapper.Map<IEnumerable<AirportToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Airport entity = _context.Airports.Include(c => c.City).First(c => c.Id == id);
            AirportByIdDto dto = _mapper.Map<AirportByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AirportToAddDto dto)
        {
            Airport entity = _mapper.Map<Airport>(dto);
            _context.Airports.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Airport entity = _context.Airports.Find(id);
            _context.Airports.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AirportToUpdateDto dto)
        {
            Airport entity = _mapper.Map<Airport>(dto);
            entity.Id = id;
            _context.Airports.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
            
        }
    }
}
