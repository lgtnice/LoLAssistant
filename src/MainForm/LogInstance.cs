using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace MainForm
{
    internal class LogInstance
    {
        static readonly LogPrinter printer = new LogPrinter();
        static LogInstance()
        {
            printer.registerObserver(new PrintOnDiskFile());
            printer.registerObserver(new PrintOnConsole());
        }
        public static void RegisterPrintOnMainForm(Action<LogLevel, string> action) => printer.registerObserver(new PrintOnMainForm(action));
        public static void Print(LogLevel level, string logText) => printer.log(level, logText);
    }
}
