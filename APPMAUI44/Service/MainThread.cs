using System;
using APPMAUI44.Core.Interface;

namespace APPMAUI44.Service
{
	public class MainThread:IMainThread
	{
		public bool IsMainThread => Microsoft.Maui.ApplicationModel.MainThread.IsMainThread;

        public void BeginInvokeOnMainThread(Action action)
        {
            Microsoft.Maui.ApplicationModel.MainThread.BeginInvokeOnMainThread(action);
        }

        public Task InvokeOnMainThreadAsync(Action action)
        {
            return Microsoft.Maui.ApplicationModel.MainThread.InvokeOnMainThreadAsync(action);
        }

        public Task<T> InvokeOnMainThreadAsync<T>(Func<T> func)
        {
            return Microsoft.Maui.ApplicationModel.MainThread.InvokeOnMainThreadAsync(func);
        }

        public Task InvokeOnMainThreadAsync(Func<Task> funcTask)
        {
            return Microsoft.Maui.ApplicationModel.MainThread.InvokeOnMainThreadAsync(funcTask);
        }

        public Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask)
        {
            return Microsoft.Maui.ApplicationModel.MainThread.InvokeOnMainThreadAsync(funcTask);
        }
    }
}

