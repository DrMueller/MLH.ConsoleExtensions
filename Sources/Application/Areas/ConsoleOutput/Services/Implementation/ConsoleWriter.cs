using System;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services.Implementation
{
    internal class ConsoleWriter : IConsoleWriter
    {
        public void Write(string text, ConsoleColor? backgroundColor, ConsoleColor? foregroundColor)
        {
            AdjustColors(backgroundColor, foregroundColor);
            Console.Write(text);
            Console.ResetColor();
        }

        public void WriteLine(string text, ConsoleColor? backgroundColor, ConsoleColor? foregroundColor)
        {
            AdjustColors(backgroundColor, foregroundColor);
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static void AdjustColors(ConsoleColor? backgroundColor, ConsoleColor? foregroundColor)
        {
            if (backgroundColor.HasValue)
            {
                Console.BackgroundColor = backgroundColor.Value;
            }

            if (foregroundColor.HasValue)
            {
                Console.ForegroundColor = foregroundColor.Value;
            }
        }
    }
}