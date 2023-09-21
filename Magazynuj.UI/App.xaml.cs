using Magazynuj.UI.ViewModels;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Magazynuj.Data.Data;
using Magazynuj.UI.View;

namespace Magazynuj.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // ta fuknckja okresla co robic po uruchomieniu
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            //MainWindow window = new MainWindow();
            //window.DataContext = new MainWindowViewModel(); // to jest powiązanie view z view model, ej ty window jestes MainWindowViewModel
            //window.Show();
            //DatabaseFacade facade = new DatabaseFacade(new WarehouseManagementContext());
            //facade.EnsureCreated();
        }
    }
}
