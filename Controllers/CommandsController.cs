using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rekt.Data;
using Rekt.Models;

namespace Rekt.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly MockCommanderRepo _repository = new MockCommanderRepo();

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();
      return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}