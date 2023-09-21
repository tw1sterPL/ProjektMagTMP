using Magazynuj.Data.Models;
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
    /// Interaction logic for AllGoodsListWindowView.xaml
    /// </summary>
    public partial class AllGoodsListWindowView : Window
    {
        public AllGoodsListWindowView()
        {
            InitializeComponent();

        }

        public Commodity GetSelectedCommodity()
        {
            return hViewModel.SelectedCommodity;
        }

        public event EventHandler<ItemSelectedEventArgs> ItemSelected;

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            AddGoodsView addGoodsView = new AddGoodsView();
            addGoodsView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addGoodsView.Show();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ItemSelected?.Invoke(this, new ItemSelectedEventArgs()
            {
                SelectedItem = hViewModel.SelectedCommodity
            });
        }
    }
    public class ItemSelectedEventArgs : EventArgs
    {
        public Commodity SelectedItem { get; set; }
    }
}
