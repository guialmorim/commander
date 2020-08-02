using System.Collections.Generic;
using Commander.Data;
using Commander.Models;

namespace Commander.Data {
    public class MockCommanderRepository : ICommanderRepository {
        public void CreateCommand(Command command) {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command) {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands() {
            var commands = new List<Command> {
                new Command { Id = 1, HowTo = "Boil an egg", Line = "boil Water", Platform = "Node" },
                new Command { Id = 2, HowTo = "BaAAAA", Line = "bodsadasdater", Platform = "Node" },
                new Command { Id = 3, HowTo = "SADSA", Line = "bodxcxer", Platform = "Node" },
                new Command { Id = 4, HowTo = "ADSas", Line = "bocxcxcxter", Platform = "Node" },
                new Command { Id = 5, HowTo = "sadD", Line = "boireter", Platform = "Node" },
                new Command { Id = 6, HowTo = "DFSDFS", Line = "borrerter", Platform = "Node" }
            };

            return commands;
        }

        public Command GetCommandById(int id) {
            return new Command { Id = 1, HowTo = "Boil an egg", Line = "boil Water", Platform = "Node" };
        }

        public bool SaveChanges() {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command) {
            throw new System.NotImplementedException();
        }
    }
}