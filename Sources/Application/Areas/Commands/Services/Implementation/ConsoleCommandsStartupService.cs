using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services.Servants;

namespace Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services.Implementation
{
    internal class ConsoleCommandsStartupService : IConsoleCommandsStartupService
    {
        private readonly IConsoleCommandsContainer _container;

        public ConsoleCommandsStartupService(IConsoleCommandsContainer container)
        {
            _container = container;
        }

        public void Start()
        {
            var commandsTask = _container.ShowCommands();
            Task.WaitAll(commandsTask);
        }
    }
}