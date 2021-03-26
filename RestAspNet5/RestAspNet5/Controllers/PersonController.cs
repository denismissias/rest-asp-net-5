using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAspNet5.Model;
using RestAspNet5.Service;

namespace RestAspNet5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {
        public IPersonService _personService { get; set; }
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Person person = _personService.GetById(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            
            return NoContent();
        }
    }
}
