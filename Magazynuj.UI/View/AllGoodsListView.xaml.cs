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
    /// Interaction logic for AllGoodsListView.xaml
    /// </summary>
    public partial class AllGoodsListView : UserControl
    {
        public AllGoodsListView()
        {
            InitializeComponent();
        }
        private void AddNewGoodsViewWindow(object sender, RoutedEventArgs e)
        {
            AddGoodsView addGoodsView = new AddGoodsView();
            addGoodsView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addGoodsView.Show();
        }
        private void DeletedGoodsViewWindow(object sender, RoutedEventArgs e)
        {
            DeletedView deletedView = new DeletedView();
            deletedView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            deletedView.Show();
        }
    }
}
