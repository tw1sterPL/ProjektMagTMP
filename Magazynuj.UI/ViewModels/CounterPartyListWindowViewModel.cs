using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using Magazynuj.UI.ViewModels.Service;
using Magazynuj.Models.Services.ForViews;

namespace Magazynuj.UI.ViewModels
{
    public class CounterPartyListWindowViewModel : CollectionViewModel<CounterPartyForAllView>
    {

        #region Constructor
        public CounterPartyListWindowViewModel()
            : base("Kontrahent")
        {

        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<CounterPartyForAllView>
                (
                from contractor in WarehouseManagementContext.Contractor
                select new CounterPartyForAllView
                {
                    ContractorCode = contractor.CodeContractor,
                    ContractorName = contractor.NameContractor,
                    AdresCity = contractor.Adres.City,
                    AdresHouseNumber = contractor.Adres.HouseNumber,
                    AdresStreet = contractor.Adres.Street,
                    NIP = contractor.PersonalData.Nip
                }
                );
        }
        #endregion
    }
}
