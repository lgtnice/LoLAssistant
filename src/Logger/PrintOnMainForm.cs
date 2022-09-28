using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.ObservePattern;

namespace Logger
{
    public class PrintOnMainForm : Observer
    {
        private readonly Action<LogLevel, string> printOnMainFormAction;
        public PrintOnMainForm(Action<LogLevel, string> action) => this.printOnMainFormAction = action;

        public void Update(LogLevel level, string logText) => this.printOnMainFormAction?.Invoke(level, logText);
    }
}
