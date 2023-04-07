using AirportAPI.DAL;
using AirportAPI.DTOs.PassengerDTOs;
using AirportAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sentry;
using System.Resources;

namespace AirportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        private readonly IHub _hub;
        public PassengersController(ApiContext context, IMapper mapper, IHub hub)
        {
            _context = context;
            _mapper = mapper;
            _hub = hub;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Passenger> entities = _context.Passengers;
            IEnumerable<PassengerToListDto> dtos = _mapper.Map<IEnumerable<PassengerToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("deleted")]
        public IActionResult GetDeleted()
        {
            IQueryable<Passenger> entities = _context.Passengers.IgnoreQueryFilters();
            IEnumerable<PassengerToListDto> dtos = _mapper.Map<IEnumerable<PassengerToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Passenger entity = _context.Passengers.Find(id);
            PassengerByIdDto dto = _mapper.Map<PassengerByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] PassengerToAddDto dto)
        {
            Passenger entity = _mapper.Map<Passenger>(dto);
            _context.Passengers.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Passenger entity = _context.Passengers.Find(id);
            _context.Passengers.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PassengerToUpdateDto dto)
        {
            Passenger entity = _mapper.Map<Passenger>(dto);
            entity.Id = id;
            _context.Passengers.Update(entity);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPatch("{id}/password")]
        public IActionResult Patch([FromRoute] int id, [FromQuery] ResetPassword resetPassword)
        {
            Passenger result = _context.Passengers.Find(id);
            if (result is not null)
            {
                if (resetPassword.Password is not null)
                {
                    result.Password = resetPassword.Password;
                    return Ok(result);
                }
                throw new NullReferenceException("Password can not be null");
            }
            return NoContent();
        }
    }
}
