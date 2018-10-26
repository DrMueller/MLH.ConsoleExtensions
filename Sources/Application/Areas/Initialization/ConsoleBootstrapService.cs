using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Models;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Services;

namespace Mmu.Mlh.ConsoleExtensions.Areas.Initialization
{
    public static class ConsoleBootstrapService
    {
        public static void Start(ContainerConfiguration containerConfig)
        {
            var container = ContainerInitializationService.CreateInitializedContainer(containerConfig);
            var commandsContainer = container.GetInstance<IConsoleCommandsContainer>();
            commandsContainer.ShowCommands();
        }
    }
}