using Magazynuj.Data.Models;
using Magazynuj.UI.ViewModels.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.UI.ViewModels
{
    public class NewInvoiceViewModel : OneViewModel<Invoice>
    {
        #region Constructor
        public NewInvoiceViewModel()
        {
            item = new Invoice();
            Commodities = new ObservableCollection<Commodity>();
        }
        #endregion
        #region Properties
        public string RateVat
        {
            get { return item.RateVat; }
            set { if (value != item.RateVat) item.RateVat = value; base.OnPropertyChanged(() => RateVat); }
        }
        #endregion
        #region Helpers 
        public override void Save()
        {
            warehouseManagementContext.Invoice.AddAsync(item);
            warehouseManagementContext.SaveChangesAsync();
        }
        #endregion

        public IList<Commodity> Commodities { get; }

        private Commodity selectedCommodity;

        public Commodity SelectedCommodity
        {
            get { return selectedCommodity; }
            set { selectedCommodity = value; OnPropertyChanged(() => SelectedCommodity); }
        }


    }
}
