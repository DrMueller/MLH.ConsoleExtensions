using Mmu.Mlh.ConsoleExtensions.Areas.Initialization;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Models;

namespace Mmu.Mlh.ConsoleExtensions.TestConsole
{
    public static class Program
    {
        public static void Main()
        {
            var containerConfig = ContainerConfiguration.CreateFromAssembly(typeof(Program).Assembly, logInitialization: true);
            ConsoleBootstrapService.Start(containerConfig);
        }
    }
}