using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;

namespace Mmu.Mlh.ConsoleExtensions.TestConsole.Areas.ConsoleCommands
{
    public class Test2 : IConsoleCommand
    {
        public string Description { get; } = "Test 2";
        public ConsoleKey Key { get; } = ConsoleKey.C;

        public Task ExecuteAsync()
        {
            Console.WriteLine("Executing Test2");
            return Task.CompletedTask;
        }
    }
}