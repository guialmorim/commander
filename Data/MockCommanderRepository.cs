using Commander.Models;
using Commander.Data;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boil an egg", Line = "boil Water", Platform = "Node" },
                new Command { Id = 2, HowTo = "BaAAAA", Line = "bodsadasdater", Platform = "Node" },
                new Command { Id = 3, HowTo = "SADSA", Line = "bodxcxer", Platform = "Node" },
                new Command { Id = 4, HowTo = "ADSas", Line = "bocxcxcxter", Platform = "Node" },
                new Command { Id = 5, HowTo = "sadD", Line = "boireter", Platform = "Node" },
                new Command { Id = 6, HowTo = "DFSDFS", Line = "borrerter", Platform = "Node" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Boil an egg", Line = "boil Water", Platform = "Node" };
        }
    }
}