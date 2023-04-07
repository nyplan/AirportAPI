using AirportAPI.DAL;
using AirportAPI.DTOs.FlightDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public FlightsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Flight> entities = _context.Flights
                .Include(c => c.OriginAirport.City)
                .Include(c => c.DestinationAirport.City)
                .Include(c => c.FlightStatus.Key)
                .Include(c => c.Pilot)
                .Include(c => c.Plane)
                .AsNoTracking();
            IEnumerable<FlightToListDto> dtos = _mapper.Map<IEnumerable<FlightToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Flight entity = _context.Flights
                .Include(c => c.OriginAirport.City)
                .Include(c => c.DestinationAirport.City)
                .Include(c => c.FlightStatus.Key)
                .Include(c => c.Pilot)
                .Include(c => c.Plane)
                .AsNoTracking()
                .First(c => c.Id == id);
            FlightByIdDto dto = _mapper.Map<FlightByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] FlightToAddDto dto)
        {
            Flight entity = _mapper.Map<Flight>(dto);
            _context.Flights.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Flight entity = _context.Flights.Find(id);
            _context.Flights.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] FlightToUpdateDto dto)
        {
            Flight entity = _mapper.Map<Flight>(dto);
            entity.Id = id;
            _context.Flights.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
