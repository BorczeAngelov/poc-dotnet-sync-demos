using System;
using System.Runtime.CompilerServices;

namespace PocWpfTaskLib.Util
{
    public static class SmartConsole
    {
        public static void WriteLine(string value, [CallerMemberName] string callerName = "")
        {
            var smartPrefix = $"({DateTime.Now:O}) {callerName}: ";
            Console.WriteLine(string.Concat(smartPrefix, value));
        }
    }
}
