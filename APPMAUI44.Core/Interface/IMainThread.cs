using System;
using System.Threading.Tasks;

namespace APPMAUI44.Core.Interface
{
	public interface IMainThread
	{
		bool IsMainThread { get; }

        void BeginInvokeOnMainThread(Action action);
        Task InvokeOnMainThreadAsync(Action action);
        Task<T> InvokeOnMainThreadAsync<T>(Func<T> func);
        Task InvokeOnMainThreadAsync(Func<Task> funcTask);
        Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask);
    }
}

