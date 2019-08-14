using System;
using System.Threading;
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
            Thread.Sleep(2000);
            return Task.CompletedTask;
        }
    }
}