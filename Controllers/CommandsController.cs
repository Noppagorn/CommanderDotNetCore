using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Commander.Controllers
{
    //api/commands [...] this will get name of "command"
    //[Route("api/command")]
    [Route("api/[controller]")]
    [ApiController] // for some default behavior
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository) //dependency inject
        {
            _repository = repository;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCammandById(int id) { // this id comfrome http request
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
