using Magazynuj.UI.ViewModels;
using Magazynuj.UI.View;
using System.Windows;

namespace Magazynuj.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenWindowCompanyDataView(object sender, RoutedEventArgs e)
        {
            CompanyDataView companyDataView = new CompanyDataView();
            companyDataView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            companyDataView.Show();
        }
        private void OpenWindowNewInvoiceView(object sender, RoutedEventArgs e)
        {
            NewInvoiceView newInvoiceView = new NewInvoiceView();
            newInvoiceView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newInvoiceView.Show();
        }
        private void WindowOpenNewCounterPartyView(object sender, RoutedEventArgs e)
        {
            NewCounterpartyView newCounterPartyView = new NewCounterpartyView();
            newCounterPartyView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newCounterPartyView.Show();
        }
    }
}
