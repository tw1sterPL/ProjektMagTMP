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

namespace Magazynuj.UI.View
{
    /// <summary>
    /// Interaction logic for SaleListView.xaml
    /// </summary>
    public partial class SaleListView : UserControl
    {
        public SaleListView()
        {
            InitializeComponent();
        }
        private void OpenWindowDelete(object sender, RoutedEventArgs e)
        {
            DeletedView deletedView = new DeletedView();
            deletedView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            deletedView.Show();
        }
        private void OpenWindowNewInvoice(object sender, RoutedEventArgs e)
        {
            NewInvoiceView newInvoiceView = new NewInvoiceView();
            newInvoiceView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newInvoiceView.Show();
        }

    }
}
