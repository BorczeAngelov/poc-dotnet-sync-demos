using System.Threading.Tasks;

namespace PocWpfTaskLib.PocAsyncCode
{
    internal class TaskResultAndAwaitTaskDelay1
    {
        internal bool StartReplay()
        {
            return StartReplayAsync().Result;
        }

        private async Task<bool> StartReplayAsync()
        {
            await Task.Delay(1); //It creates Deadlock on GUI Thread
            return true;
        }
    }
}
