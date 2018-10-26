using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services.Implementation;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services.Implementation;
using Mmu.Mlh.ConsoleExtensions.Areas.ExceptionHandling.Services;
using Mmu.Mlh.ConsoleExtensions.Areas.ExceptionHandling.Services.Implementation;
using Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services;
using Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services.Implementation;
using StructureMap;

namespace Mmu.Mlh.ConsoleExtensions.Infrastructure.DependencyInjection
{
    public class ConsoleExtensionsRegistry : Registry
    {
        public ConsoleExtensionsRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<ConsoleExtensionsRegistry>();
                    scanner.WithDefaultConventions();
                });

            For<IConsoleCommandsContainer>().Use<ConsoleCommandsContainer>().Singleton();
            For<IConsoleActionHandler>().Use<ConsoleActionHandler>().Singleton();
            For<IConsoleWriter>().Use<ConsoleWriter>().Singleton();
            For<IExceptionHandler>().Use<ExceptionHandler>().Singleton();
        }
    }
}