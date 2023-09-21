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
    /// Interaction logic for CompanyDataView.xaml
    /// </summary>
    public partial class CompanyDataView : Window
    {
        public CompanyDataView()
        {
            InitializeComponent();
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            BankView bankView = new BankView();
            bankView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            bankView.Show();
        }

        private void OpenWindowDeletedView(object sender, RoutedEventArgs e)
        {
            DeletedSecondView deletedSecondView = new DeletedSecondView();
            deletedSecondView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            deletedSecondView.Show();
        }
    }
}
