using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;

namespace Mmu.Mlh.ConsoleExtensions.TestConsole.Areas.ConsoleCommands
{
    public class Test1 : IConsoleCommand
    {
        public string Description { get; } = "Test 1";
        public ConsoleKey Key { get; } = ConsoleKey.F1;

        public Task ExecuteAsync()
        {
            Console.WriteLine("Executing Test1");
            return Task.CompletedTask;
        }
    }
}