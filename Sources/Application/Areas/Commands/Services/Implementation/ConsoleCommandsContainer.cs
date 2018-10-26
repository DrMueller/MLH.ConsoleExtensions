using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services;
using Mmu.Mlh.LanguageExtensions.Areas.Collections;

namespace Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services.Implementation
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

        public void ShowCommands()
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            ListenForInputs();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
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