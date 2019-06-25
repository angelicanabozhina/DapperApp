using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperApp.Models;
using DapperApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DapperApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IClientRepository _clientRepository;

        public ValuesController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<ClientDTO> Get()
        {
            return _clientRepository.Get(new List<int> {1, 2});
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
