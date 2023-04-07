using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.DTOs.TicketDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public TicketsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Ticket> entities = _context.Tickets
                .Include(c => c.Booking.Passenger)
                .Include(c => c.Booking.Flight.OriginAirport.City)
                .Include(c => c.Booking.Flight.DestinationAirport.City)
                .Include(c => c.Booking.Flight.FlightStatus.Key)
                .Include(c => c.Booking.Flight.Pilot)
                .Include(c => c.Booking.Flight.Plane)
                .Include(c => c.TicketType.Key)
                .AsNoTracking();
            IEnumerable<TicketToListDto> dtos = _mapper.Map<IEnumerable<TicketToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Ticket entity = _context.Tickets
                .Include(c => c.Booking.Passenger)
                .Include(c => c.Booking.Flight.OriginAirport.City)
                .Include(c => c.Booking.Flight.DestinationAirport.City)
                .Include(c => c.Booking.Flight.FlightStatus.Key)
                .Include(c => c.Booking.Flight.Pilot)
                .Include(c => c.Booking.Flight.Plane)
                .Include(c => c.TicketType.Key)
                .AsNoTracking()
                .First(c => c.Id == id);
            TicketByIdDto dto = _mapper.Map<TicketByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TicketToAddDto dto)
        {
            Ticket entity = _mapper.Map<Ticket>(dto);
            _context.Tickets.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Ticket entity = _context.Tickets.Find(id);
            _context.Tickets.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] TicketToUpdateDto dto)
        {
            Ticket entity = _mapper.Map<Ticket>(dto);
            entity.Id = id;
            _context.Tickets.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
