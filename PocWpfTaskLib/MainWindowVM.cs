using PocWpfTaskLib.PocAsyncCode;

namespace PocWpfTaskLib
{
    public class MainWindowVM
    {
        /// <summary>
        /// Make sure it is run on GUI Thread
        /// </summary>
        internal void PoC01_TaskResultAndAwaitTaskDelay0()
        {
            var result = new TaskResultAndAwaitTaskDelay0().StartReplay();
        }

        /// <summary>
        /// Make sure it is run on GUI Thread
        /// </summary>
        internal void PoC02_TaskResultAndAwaitTaskDelay1()
        {
            var result = new TaskResultAndAwaitTaskDelay1().StartReplay();
        }
    }
}
