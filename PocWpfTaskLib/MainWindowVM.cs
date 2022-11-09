using PocWpfTaskLib.PocAsyncCode;
using System;

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

        internal void PoC01_TaskResultAndAwaitTaskDelay0_QueueDispatcher()
        {
            var result = new TaskResultAndAwaitTaskDelay0_QueueDispatcher().StartReplay();
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
