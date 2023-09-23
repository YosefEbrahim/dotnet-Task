using dotnet_intern.Services;
using dotnet_task;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProgram _service;
        public ProgramController(IProgram service)
        {
            this._service = service;

        }

        [HttpGet("{id}")]
        public async Task<ProgramDetails> Get(int id)
        {
            var result =await _service.GetAsync(id);
            return result;
        }

        // POST api/<ProgramController>
        [HttpPost]
        public async void Post([FromBody] ProgramDetails value)
        {
          await  _service.AddAsync(value);
        }

        // PUT api/<ProgramController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] ProgramDetails value)
        {
          await  _service.UpdateAsync(id, value);
        }

    }
}
