
using System.Collections.Generic;
using Rekt.Models;

namespace Rekt.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}