using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.ExceptionHandling.Services;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services.Implementation
{
    internal class ConsoleActionHandler : IConsoleActionHandler
    {
        private readonly IExceptionHandler _exceptionHandler;

        public ConsoleActionHandler(IExceptionHandler exceptionHandler)
        {
            _exceptionHandler = exceptionHandler;
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Wanted here")]
        public void HandleAction(Action callback)
        {
            try
            {
                callback();
            }
            catch (Exception ex)
            {
                _exceptionHandler.HandleException(ex);
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Wanted here")]
        public async Task HandleAsyncAction(Func<Task> callback)
        {
            try
            {
                await callback();
            }
            catch (Exception ex)
            {
                _exceptionHandler.HandleException(ex);
            }
        }
    }
}