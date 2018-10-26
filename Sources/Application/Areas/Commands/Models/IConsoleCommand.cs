using System;
using System.Threading.Tasks;

namespace Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models
{
    public interface IConsoleCommand
    {
        string Description { get; }
        ConsoleKey Key { get; }

        Task ExecuteAsync();
    }
}