using AutoTyper.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace AutoTyper
{
    public static class Program
    {
        public static TbsLoggerSink LoggerSink = new TbsLoggerSink();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///Generate Host Builder and Register the Services for DI
            var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddScoped<Form1>();
                   //services.AddScoped<IBusinessLayer, BusinessLayer>();
                   //services.AddSingleton<IDataAccessLayer, CDataAccessLayer>();


                   //Add Serilog
                   var serilogLogger = new LoggerConfiguration()
                   //.WriteTo.File("TheCodeBuzz.txt")
                   .WriteTo.Sink(LoggerSink)
                   .CreateLogger();


                   services.AddLogging(x =>
                              {
                                  x.SetMinimumLevel(LogLevel.Information);
                                  x.AddSerilog(logger: serilogLogger, dispose: true);
                              });

               });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}