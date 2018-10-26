using System;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services
{
    public interface IConsoleWriter
    {
        void Write(string text, ConsoleColor? backgroundColor, ConsoleColor? foregroundColor);

        void WriteLine(string text, ConsoleColor? backgroundColor, ConsoleColor? foregroundColor);
    }
}