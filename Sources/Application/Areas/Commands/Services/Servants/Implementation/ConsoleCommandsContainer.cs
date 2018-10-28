using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services;
using Mmu.Mlh.LanguageExtensions.Areas.Collections;

namespace Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services.Servants.Implementation
{
    internal class ConsoleCommandsContainer : IConsoleCommandsContainer
    {
        private readonly IConsoleActionHandler _consoleActionHandler;
        private readonly IReadOnlyCollection<IConsoleCommand> _consoleCommands;

        public ConsoleCommandsContainer(IEnumerable<IConsoleCommand> consoleCommands, IConsoleActionHandler consoleActionHandler)
        {
            _consoleActionHandler = consoleActionHandler;
            _consoleCommands = consoleCommands.OrderBy(c => c.Key).ToList();
        }

        public async Task ShowCommands()
        {
            await ListenForInputs();
        }

        private void DisplayCommands()
        {
            _consoleCommands.ForEach(command => Console.WriteLine($"{command.Key} - {command.Description}"));
        }

        private async Task ListenForInputs()
        {
            await _consoleActionHandler.HandleAsyncAction(
                async () =>
                {
                    DisplayCommands();
                    Console.WriteLine();

                    var keyInfo = Console.ReadKey(true);

                    var command = _consoleCommands.FirstOrDefault(f => f.Key == keyInfo.Key);
                    if (command == null)
                    {
                        Console.WriteLine($"No Command for {keyInfo.Key} found!");
                        await ListenForInputs();
                    }

                    Console.WriteLine($"Executing {keyInfo.Key}..");
                    await command.ExecuteAsync();
                });

            await ListenForInputs();
        }
    }
}