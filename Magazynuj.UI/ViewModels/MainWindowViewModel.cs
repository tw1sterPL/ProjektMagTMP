using Magazynuj.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Magazynuj.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkSpaceViewModel> _Workspaces;
        #endregion
        #region ToolBarComands

        private BaseCommand getCommand(BaseCommand _command, WorkSpaceViewModel _workspase)
        {
            if (_command == null)
                _command = new BaseCommand(() => Create(_workspase));
            return _command;
        }

        private BaseCommand _CreateCounterPartyCommand;
        public ICommand CreateCounterPartyCommand
        {
            get
            {
                return getCommand(_CreateCounterPartyCommand, new CounterPartyListViewModel());
            }
        }
        private BaseCommand _CreateSaleListCommand;
        public ICommand CreateSaleListCommand
        {
            get
            {
                return getCommand(_CreateSaleListCommand, new SaleListAllViewModel());
            }
        }
        private BaseCommand _CreateNewCounterPartyCommand;
        public ICommand CreateNewCounterPartyCommand
        {
            get
            {
                return getCommand(_CreateNewCounterPartyCommand, new NewCounterpartyViewModel());
            }
        }
        private BaseCommand _CreateDeleteCommand;
        public ICommand CreateDeleteCommand
        {
            get
            {
                return getCommand(_CreateDeleteCommand, new DeleteViewModel());
            }
        }
        private BaseCommand _CreateNewInvoiceCommand;
        public ICommand CreateNewInvoiceCommand
        {
            get
            {
                return getCommand(_CreateNewInvoiceCommand, new NewInvoiceViewModel());
            }
        }
        private BaseCommand _CreateCounterListWindowCommand;
        public ICommand CreateCounterListWindowCommand
        {
            get
            {
                return getCommand(_CreateCounterListWindowCommand, new CounterPartyListWindowViewModel());
            }
        }
        private BaseCommand _CreateDeletedSecondWindowCommand;
        public ICommand CreateDeletedSecondWindowCommand
        {
            get
            {
                return getCommand(_CreateDeletedSecondWindowCommand, new DeletedSecondViewModel());
            }
        }
        private BaseCommand _CreateDiscountInvoiceViewWindowCommand;
        public ICommand CreateDiscountInvoiceViewWindowCommand
        {
            get
            {
                return getCommand(_CreateDiscountInvoiceViewWindowCommand, new DiscountInvoiceViewModel());
            }
        }
        private BaseCommand _CreateGoodsListCommand;
        public ICommand CreateGoodsListCommand => getCommand(_CreateGoodsListCommand, new AllGoodsListViewModel());

        private BaseCommand _CreateCorrectiveInvoiceListCommand;
        public ICommand CreateCorrectiveInvoiceListCommand => getCommand(_CreateCorrectiveInvoiceListCommand, new CorrectiveInvoiceListViewModel());

        #endregion
        #region NewWindow

        #endregion
        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel("Kontrahenci",new BaseCommand(()=>this.Create(new CounterPartyListViewModel()))), //
                new CommandViewModel("Lista towarów",new BaseCommand(()=>this.Create(new AllGoodsListViewModel()))), //
                new CommandViewModel("Kontrahenci",new BaseCommand(()=>this.Create(new CounterPartyListWindowViewModel()))), //
                //new CommandViewModel("Wszystkie towary",new BaseCommand(()=>this.ShowAllTowar())), //          
            };
        }
        #endregion
        #region Workspaces
        public ObservableCollection<WorkSpaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkSpaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkSpaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkSpaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkSpaceViewModel workspace = sender as WorkSpaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion
        #region PrivateHelpers
        private void Create(WorkSpaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }
        private void SetActiveWorkspace(WorkSpaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
        #endregion

    }
}
