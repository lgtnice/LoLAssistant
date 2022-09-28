using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.ObservePattern;

namespace Logger
{
    public class LogPrinter : Subject
    {
        private readonly List<Observer> observers = new List<Observer>();
        public LogPrinter()
        {

        }

        public void notify(LogLevel level, string logText)
        {
            foreach(Observer item in this.observers)
            {
                item.Update(level, logText);
            }
        }
        public void log(LogLevel level, string logText) => this.notify(level, logText);
        public void registerObserver(Observer o) => this.observers.Add(o);
        public void removeObserver(Observer o)
        {
            if(this.observers.Contains(o))
            {
                _ = this.observers.Remove(o);
            }
        }
    }
}
