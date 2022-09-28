using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.ObservePattern
{
    public interface Observer
    {
        void Update(LogLevel level, string logText);
    }
}
