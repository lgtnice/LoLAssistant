using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace MainForm
{
    internal class CommonConstant
    {
        private static LogLevel userLogLevel;
        internal static LogLevel UserLogLevel
        {
            get => userLogLevel;
            set
            {
                userLogLevel = value;
            }
        }
    }
}
