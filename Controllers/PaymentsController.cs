using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.DTOs.PaymentDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public PaymentsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Payment> entities = _context.Payments
                .Include(c => c.Booking.Flight.OriginAirport.City)
                .Include(c => c.Booking.Flight.DestinationAirport.City)
                .Include(c => c.Booking.Flight.Plane)
                .Include(c => c.Booking.Flight.Pilot)
                .Include(c => c.Booking.Flight.FlightStatus.Key)
                .Include(c => c.Booking.Passenger)
                .AsNoTracking();
            IEnumerable<PaymentToListDto> dtos = _mapper.Map<IEnumerable<PaymentToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Payment entity = _context.Payments
                .Include(c => c.Booking.Flight.OriginAirport.City)
                .Include(c => c.Booking.Flight.DestinationAirport.City)
                .Include(c => c.Booking.Flight.Plane)
                .Include(c => c.Booking.Flight.Pilot)
                .Include(c => c.Booking.Flight.FlightStatus.Key)
                .Include(c => c.Booking.Passenger)
                .AsNoTracking()
                .First(c => c.Id == id);
            PaymentByIdDto dto = _mapper.Map<PaymentByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] PaymentToAddDto dto)
        {
            Payment entity = _mapper.Map<Payment>(dto);
            _context.Payments.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Payment entity = _context.Payments.Find(id);
            _context.Payments.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PaymentToUpdateDto dto)
        {
            Payment entity = _mapper.Map<Payment>(dto);
            entity.Id = id;
            _context.Payments.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
