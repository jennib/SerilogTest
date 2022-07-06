using Serilog;
using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SerilogTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs args)
        {
            // Setup Serilog 
            using var log = new LoggerConfiguration()
        .WriteTo.Debug()
        .WriteTo.File("logs/AppLog.txt", rollingInterval: RollingInterval.Day)
        //.WriteTo.File(new CompactJsonFormatter(), "log.txt")
        .CreateLogger();
            
            // This is what a log message looks like.
            log.Information("App Startup");

            // Make the MainWindow and pass in the serilog
            MainWindow mainWindows = new MainWindow(log);
            mainWindows.Show();
            
            // Call the base method that we overrode
            base.OnStartup(args);
        }
    }
}
