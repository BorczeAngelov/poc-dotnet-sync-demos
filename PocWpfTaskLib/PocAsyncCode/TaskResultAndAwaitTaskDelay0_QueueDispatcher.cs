using PocWpfTaskLib.Util;
using System.Threading;
using System.Threading.Tasks;

namespace PocWpfTaskLib.PocAsyncCode
{
    internal class TaskResultAndAwaitTaskDelay0_QueueDispatcher
    {
        internal bool StartReplay()
        {
            QueueDispatcher();
            Thread.Sleep(5_000); //Mimic 5 seconds work on GUI Thread. Make sure there is work on DispatcherQueue
            return StartReplayAsync().Result; //TODO: Read docs about .Result
        }

        private async Task<bool> StartReplayAsync()
        {
            SmartConsole.WriteLine("(1/5) Main Thread before await Task.Delay(0)");
            await Task.Delay(0); //There is no context switch. Main Thread will not work on the DispatcherQueue. This is no-op. This is garbage.
            SmartConsole.WriteLine("(2/5) Main Thread after await Task.Delay(0)");

            return true;
        }

        private async void QueueDispatcher()
        {
            SmartConsole.WriteLine("(3/5) Main thread {Thread.CurrentThread.ManagedThreadId} is here. Before await");

            await Task.Run(async () =>
            {
                await Task.Delay(2_000); //Mimic 2 seconds work
                SmartConsole.WriteLine("(4/5) Worker thread {Thread.CurrentThread.ManagedThreadId} is here");
            });

            SmartConsole.WriteLine("(5/5) Main thread {Thread.CurrentThread.ManagedThreadId} is here. After await");
        }
    }
}
