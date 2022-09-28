using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.ObservePattern
{
    internal interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notify(LogLevel level, string logText);
        
    }
}
