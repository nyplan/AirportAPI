using AirportAPI.DAL;
using AirportAPI.DTOs.FeedbackDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ToolsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("stars")]
        public IActionResult GetStars()
        {
            IQueryable<EnumValue> entities = _context.EnumValues.Where(c => c.KeyId == 3).AsNoTracking();
            return Ok(entities);
        }
        [HttpGet("ticketTypes")]
        public IActionResult GetTicketTypes()
        {
            IQueryable<EnumValue> entities = _context.EnumValues.Where(c => c.KeyId == 2).AsNoTracking();
            return Ok(entities);
        }
        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            IQueryable<City> entities = _context.Cities.AsNoTracking();
            return Ok(entities);
        }
        [HttpGet("flightStatuses")]
        public IActionResult GetFlightStatuses()
        {
            IQueryable<EnumValue> entities = _context.EnumValues.Where(c => c.KeyId == 1).AsNoTracking();
            return Ok(entities);
        }
        [HttpGet("pilots")]
        public IActionResult GetPilots()
        {
            IQueryable<Pilot> entities = _context.Pilots.AsNoTracking();
            return Ok(entities);
        }
        [HttpGet("planes")]
        public IActionResult GetPlanes()
        {
            IQueryable<Plane> entities = _context.Planes.AsNoTracking();
            return Ok(entities);
        }
    }
}
