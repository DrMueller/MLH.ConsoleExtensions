using System;
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