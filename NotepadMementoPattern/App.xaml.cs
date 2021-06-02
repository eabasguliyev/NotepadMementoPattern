using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NotepadMementoPattern.ViewModels;
using NotepadMementoPattern.Views;

namespace NotepadMementoPattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(),
            };

            mainWindow.ShowDialog();
        }
    }
}
