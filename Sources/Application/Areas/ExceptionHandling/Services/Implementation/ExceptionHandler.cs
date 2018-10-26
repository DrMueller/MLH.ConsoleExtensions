using System;
using System.Text;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.LanguageExtensions.Areas.Exceptions;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ExceptionHandling.Services.Implementation
{
    internal class ExceptionHandler : IExceptionHandler
    {
        private readonly IConsoleWriter _consoleWriter;

        public ExceptionHandler(IConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
        }

        public void HandleException(Exception exception)
        {
            var innerMostException = exception.GetMostInnerException();
            var sb = new StringBuilder();
            sb.Append("Exception Message: ");
            sb.AppendLine(innerMostException.Message);
            sb.Append("Exception Type: ");
            sb.AppendLine(innerMostException.GetType().Name);
            sb.Append("Stack Trace: ");
            sb.AppendLine(innerMostException.StackTrace);

            _consoleWriter.WriteLine(sb.ToString(), null, ConsoleColor.Red);
        }
    }
}