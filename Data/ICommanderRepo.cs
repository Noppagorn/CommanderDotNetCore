using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChange();

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
    }
}
