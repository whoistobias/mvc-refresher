using System.Collections.Generic;
using Rekt.Models;

namespace Rekt.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
        new Command { Id = 1, HowTo = "Boil an apple", Line = "Pick Apple", Platform = "poo" },
        new Command { Id = 2, HowTo = "Boil an jam", Line = "Make jam", Platform = "rekt you" },
      };

      return commands;
    }

    public Command GetCommandById(int Id)
    {
      return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
    }
  }
}