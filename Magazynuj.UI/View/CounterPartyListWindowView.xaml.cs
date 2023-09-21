using Magazynuj.Data.Data;
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
    /// Logika interakcji dla klasy CounterPartyListWindowView.xaml
    /// </summary>
    public partial class CounterPartyListWindowView : Window
    {
        public CounterPartyListWindowView()
        {
            InitializeComponent();
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            NewCounterpartyView newCounterparty = new NewCounterpartyView();
            newCounterparty.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newCounterparty.Show();
        }
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var query =
        //    from company in warehouseManagementContext.Company
        //    select new { company.Name };

        //    dataGrid1.ItemsSource = query.ToList();
        //}

    }
}
