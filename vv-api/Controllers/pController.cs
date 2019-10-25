using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using vv_api.Services.Interface;

namespace vv_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pController : ControllerBase
    {
        private readonly IPontoService _pontoService ;

        public pController(IPontoService pontoService)
        {
            _pontoService = pontoService;
        }

        // GET api/p
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var pontos = _pontoService.ObterPontos();
            return pontos;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}