using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Magazynuj.UI.ViewModels.Service
{
    public abstract class OneViewModel<T> : WorkSpaceViewModel
    {
        #region Fields  
        public WarehouseManagementContext warehouseManagementContext { get; set; }
        public Action CloseAction { get; set; }
        public T item { get; set; }
        #endregion
        #region Constructor
        public OneViewModel()
        {
            warehouseManagementContext = new WarehouseManagementContext();
        }
        #endregion
        #region Command
        private BaseCommand _SaveClose;
        public ICommand SaveClose
        {
            get
            {
                if (_SaveClose == null)
                {
                    _SaveClose = new BaseCommand(() => saveClose());
                }

                return _SaveClose;
            }
        }
        private BaseCommand _Close;
        public ICommand Close
        {
            get
            {
                if (_Close == null)
                {
                    _Close = new BaseCommand(() => CloseWindow());
                }

                return _Close;
            }
        }
        #endregion
        #region Helpers 
        public abstract void Save();



        private void saveClose()
        {
            Save();
            CloseAction();
        }
        private void CloseWindow()
        {
            CloseAction();
        }
        #endregion
    }
}
