using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SerilogTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Take the created Serilog Instance as a parameter.
        public MainWindow(ILogger logger)
        {
            // Create local name for the Serilog we passed in.
            Log.Logger = logger;
            
            // Write a log message.
            Log.Information("The global logger has been configured");
            
            // Finish setting up the window.
            InitializeComponent();
        }
    }
}
