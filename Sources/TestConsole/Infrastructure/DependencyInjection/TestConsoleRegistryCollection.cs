using Lamar;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;

namespace Mmu.Mlh.ConsoleExtensions.TestConsole.Infrastructure.DependencyInjection
{
    public class TestConsoleRegistryCollection : ServiceRegistry
    {
        public TestConsoleRegistryCollection()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<TestConsoleRegistryCollection>();
                    scanner.AddAllTypesOf<IConsoleCommand>();

                    scanner.WithDefaultConventions();
                });
        }
    }
}