using System;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ExceptionHandling.Services
{
    public interface IExceptionHandler
    {
        void HandleException(Exception exception);
    }
}