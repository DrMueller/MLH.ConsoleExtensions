using System;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services
{
    public interface IConsoleWriter
    {
        void Write(string text, ConsoleColor? backgroundColor = ConsoleColor.Black, ConsoleColor? foregroundColor = ConsoleColor.Gray);

        void WriteLine(string text, ConsoleColor? backgroundColor = ConsoleColor.Black, ConsoleColor? foregroundColor = ConsoleColor.Gray);
    }
}