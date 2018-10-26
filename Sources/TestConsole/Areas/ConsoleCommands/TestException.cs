using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;

namespace Mmu.Mlh.ConsoleExtensions.TestConsole.Areas.ConsoleCommands
{
    public class TestException : IConsoleCommand
    {
        public string Description { get; } = "Throw Exception!";
        public ConsoleKey Key { get; } = ConsoleKey.D1;

        public Task ExecuteAsync()
        {
            throw new Exception("Hello Exception!");
        }
    }
}