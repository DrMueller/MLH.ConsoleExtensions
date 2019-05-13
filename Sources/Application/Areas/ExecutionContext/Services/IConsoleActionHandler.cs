using System;
using System.Threading.Tasks;

namespace Mmu.Mlh.ConsoleExtensions.Areas.ExecutionContext.Services
{
    public interface IConsoleActionHandler
    {
        void HandleAction(Action callback);

        Task HandleAsyncAction(Func<Task> callback);
    }
}