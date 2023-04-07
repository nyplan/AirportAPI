using AirportAPI.DAL;
using AirportAPI.DTOs.AirportDTOs;
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
    public class FeedbacksController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public FeedbacksController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Feedback> entities = _context.Feedbacks.AsNoTracking();
            IEnumerable<FeedbackToListDto> dtos = _mapper.Map<IEnumerable<FeedbackToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Feedback entity = _context.Feedbacks.Find(id);
            FeedbackByIdDto dto = _mapper.Map<FeedbackByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] FeedbackToAddDto dto)
        {
            Feedback entity = _mapper.Map<Feedback>(dto);
            _context.Feedbacks.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Feedback entity = _context.Feedbacks.Find(id);
            _context.Feedbacks.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] FeedbackToUpdateDto dto)
        {
            Feedback entity = _mapper.Map<Feedback>(dto);
            entity.Id = id;
            _context.Feedbacks.Update(entity);
            _context.SaveChanges();
            return Ok(entity);

        }
    }
}
