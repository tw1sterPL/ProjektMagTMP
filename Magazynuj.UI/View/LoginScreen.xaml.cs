using Magazynuj.Data.Data;
using Magazynuj.UI.ViewModels;
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
using System.Windows.Shapes;

namespace Magazynuj.UI.View
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public void GrantAccess()
        {
            //base.OnStartup(e);
            // ta fuknckja okresla co robic po uruchomieniu
            MainWindow window = new MainWindow();
            window.DataContext = new MainWindowViewModel(); // to jest powiązanie view z view model, ej ty window jestes MainWindowViewModel
            window.Show();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Password;


            using (WarehouseManagementContext context = new WarehouseManagementContext())
            {
                bool userfound = context.DataAces.Any(user => user.Login == Username && user.Password == Password);
                if (userfound)
                {
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono");
                }
            }

        }
    }
}
