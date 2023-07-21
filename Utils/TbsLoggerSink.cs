using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTyper.Utils
{
    public class TbsLoggerSink : ILogEventSink
    {
        public event EventHandler NewLogHandler;

        public TbsLoggerSink() { }

        public void Emit(LogEvent logEvent)
        {
#if DEBUG
            Console.WriteLine($"{logEvent.Timestamp}] {logEvent.MessageTemplate}");
#endif
            NewLogHandler?.Invoke(typeof(TbsLoggerSink), new LogEventArgs() { Log = logEvent });
        }
    }

    public class LogEventArgs : EventArgs
    {
        public LogEvent Log { get; set; }
    }
}
