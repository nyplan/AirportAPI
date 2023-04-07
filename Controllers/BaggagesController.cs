using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.DTOs.BaggageDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaggagesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public BaggagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Baggage> entities = _context.Baggages.Include(c => c.Booking.Passenger).AsNoTracking();
            IEnumerable<BaggageToListDto> dtos = _mapper.Map<IEnumerable<BaggageToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Baggage entity = _context.Baggages.Include(c => c.Booking.Passenger).AsNoTracking().First(c => c.Id == id);
            BaggageByIdDto dto = _mapper.Map<BaggageByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] BaggageToAddDto dto)
        {
            Baggage entity = _mapper.Map<Baggage>(dto);
            _context.Baggages.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Baggage entity = _context.Baggages.Find(id);
            _context.Baggages.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] BaggageToUpdateDto dto)
        {
            Baggage entity = _mapper.Map<Baggage>(dto);
            entity.Id = id;
            _context.Baggages.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
