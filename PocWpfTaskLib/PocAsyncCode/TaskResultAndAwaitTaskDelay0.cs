using System.Threading.Tasks;

namespace PocWpfTaskLib.PocAsyncCode
{
    internal class TaskResultAndAwaitTaskDelay0
    {
        internal bool StartReplay()
        {
            return StartReplayAsync().Result; //TODO: Read docs about .Result
        }

        private async Task<bool> StartReplayAsync()
        {
            await Task.Delay(0); /// Seems there is no effect. For more details see: <see cref="TaskResultAndAwaitTaskDelay0_QueueDispatcher"/>
            return true;
        }
    }
}
