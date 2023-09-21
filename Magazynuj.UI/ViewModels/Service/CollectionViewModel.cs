using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magazynuj.UI.ViewModels.Service
{
    public abstract class CollectionViewModel<T> : WorkSpaceViewModel
    {
        #region Fields
        private readonly WarehouseManagementContext warehouseManagementContext;
        public WarehouseManagementContext WarehouseManagementContext
        {
            get { return warehouseManagementContext; }
        }
        private BaseCommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => Load());
                return _LoadCommand;
            }

        }
        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    Load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion
        #region Constructor
        public CollectionViewModel(string displayName)
        {
            base.DisplayName = displayName;
            this.warehouseManagementContext = new WarehouseManagementContext();
        }
        #endregion
        #region Helpers
        public abstract void Load();
        #endregion
    }
}
