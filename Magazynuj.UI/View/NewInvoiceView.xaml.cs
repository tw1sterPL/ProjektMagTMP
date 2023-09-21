using Magazynuj.UI.View;
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
    /// Logika interakcji dla klasy NewInvoiceView.xaml
    /// </summary>
    public partial class NewInvoiceView : Window
    {
        public NewInvoiceView()
        {
            InitializeComponent();
            viewModel = hViewModel;
        }
        private NewInvoiceViewModel viewModel;
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            CounterPartyListWindowView counterPartyListWindowView = new CounterPartyListWindowView();
            counterPartyListWindowView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            counterPartyListWindowView.Show();
        }
        private void OpenWindowNewDiscount(object sender, RoutedEventArgs e)
        {
            DiscountInvoiceView discountInvoiceView = new DiscountInvoiceView();
            discountInvoiceView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            discountInvoiceView.Show();
        }
        private void AddNewGoodsWindow(object sender, RoutedEventArgs e)
        {
            AllGoodsListWindowView allGoodsListWindowView = new AllGoodsListWindowView();
            allGoodsListWindowView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            allGoodsListWindowView.ItemSelected += AllGoodsListWindowView_ItemSelected;
            allGoodsListWindowView.Show();
        }

        private void AllGoodsListWindowView_ItemSelected(object? sender, ItemSelectedEventArgs e)
        {
            if (e.SelectedItem != null)
                hViewModel.Commodities.Add(e.SelectedItem);
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedElement = viewModel.SelectedCommodity;
        }
    }
}
