using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var command = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boild an egg", Line = "Boil water", Platform = "kattle & Pen" },
                new Command { Id = 1, HowTo = "cut bread", Line = "get knige", Platform = "kattle & Pen1" },
                new Command { Id = 2, HowTo = "make cup of tea", Line = "Place teabag in cup", Platform = "kattle & Pen2"},
            };
            return command;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id =  0, HowTo =  "Boild an egg", Line = "Boil water", Platform = "kattle & Pen" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
