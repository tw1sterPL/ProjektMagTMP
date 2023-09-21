using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.Helpers;
using Magazynuj.UI.ViewModels.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magazynuj.UI.ViewModels
{
    public class AllGoodsListWindowViewModel : CollectionViewModel<Commodity>
    {

        #region Constructor
        public AllGoodsListWindowViewModel()
            : base("Towary")
        {

        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Commodity>
            (
                from commodity in WarehouseManagementContext.Commodity
                select commodity
            );
        }
        #endregion

        private Commodity selectedCommodity;

        public Commodity SelectedCommodity
        {
            get { return selectedCommodity; }
            set { selectedCommodity = value; OnPropertyChanged(() => SelectedCommodity); }
        }
    }
}
