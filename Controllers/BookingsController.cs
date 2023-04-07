using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.DTOs.BookingDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public BookingsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Booking> entities = _context.Bookings
                .Include(c => c.Flight.FlightStatus.Key)
                .Include(c => c.Flight.Plane)
                .Include(c => c.Flight.Pilot)
                .Include(c => c.Flight.OriginAirport.City)
                .Include(c => c.Flight.DestinationAirport.City)
                .Include(c => c.Passenger)
                .AsNoTracking();
            IEnumerable<BookingToListDto> dtos = _mapper.Map<IEnumerable<BookingToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Booking entity = _context.Bookings
                .Include(c => c.Flight.FlightStatus.Key)
                .Include(c => c.Flight.Plane)
                .Include(c => c.Flight.Pilot)
                .Include(c => c.Flight.OriginAirport.City)
                .Include(c => c.Flight.DestinationAirport.City)
                .Include(c => c.Passenger)
                .AsNoTracking()
                .First(c => c.Id == id);
            BookingByIdDto dto = _mapper.Map<BookingByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] BookingToAddDto dto)
        {
            Booking entity = _mapper.Map<Booking>(dto);
            _context.Bookings.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Booking entity = _context.Bookings.Find(id);
            _context.Bookings.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] BookingToUpdateDto dto)
        {
            Booking entity = _mapper.Map<Booking>(dto);
            entity.Id = id;
            _context.Bookings.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
