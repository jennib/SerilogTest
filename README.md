# SerilogTest

Very basic WPF app to test Serilog for logging from the program.  This uses the fantastic Serilog porject https://serilog.net/

In MainWindows I added a Logger parameter:  public MainWindow(ILogger logger)

In App.xaml I removed: StartupUri="MainWindow.xaml".  This is because in App.xaml.cs I start the MainWindow and pass it the Logger

From NuGet I installed

- Serilog.Sinks.Debug (for logging to the output window)
- Serilog.Sinks.File (for logging to a file)
- Serilog.Formatting.Compact (for optionally logging JSON to the file)

This is not the official way that Serilog suggest you do this, it is just what worked for me.

