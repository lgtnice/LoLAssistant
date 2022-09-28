using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.ObservePattern;
using log4net;

namespace Logger
{
    public class PrintOnDiskFile : Observer
    {
        private readonly ILog log;
        public PrintOnDiskFile()
        {
            _ = log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net.config"));
            this.log = LogManager.GetLogger("FileLogger");
        }

        public void Update(LogLevel level, string logText)
        {
            switch(level)
            {
                case LogLevel.Debug:
                    this.log.Debug(logText);
                    break;
                case LogLevel.Info:
                    this.log.Info(logText);
                    break;
                case LogLevel.Error:
                    this.log.Error(logText);
                    break;
                case LogLevel.DoNotPrintLog:
                    break;
                default:
                    break;
            }
        }
    }
}
