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
    /// Interaction logic for CorrectiveInvoiceListView.xaml
    /// </summary>
    public partial class CorrectiveInvoiceListView : UserControl
    {
        public CorrectiveInvoiceListView()
        {
            InitializeComponent();
        }

        private void OpenWindowAddCorrective(object sender, RoutedEventArgs e)
        {
            AddCorrectiveInvoiceView addCorrectiveInvoiceView = new AddCorrectiveInvoiceView();
            addCorrectiveInvoiceView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addCorrectiveInvoiceView.Show();
        }
    }
}
