using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todolistwebapp.Repositories;
using todolistwebapp.Requests;

namespace todolistwebapp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITodoListRepository repository;
        public TaskController(ITodoListRepository repository)
        {
            this.repository = repository;

        }
        [HttpPost("Addtolist")]
        public IActionResult Addtolist(Addtask data)
        {
            return Ok(repository.Addtolist(data));
        }
        [HttpGet("GettaskById")]
        public IActionResult GettaskById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.GettaskById(id));
        }
        [HttpGet("Deletetask")]
        public IActionResult Deletetask(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.Deletetask(id));
        }
    }
}
