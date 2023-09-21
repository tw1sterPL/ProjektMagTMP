using GalaSoft.MvvmLight.Command;
using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.Helpers;
using Magazynuj.UI.ViewModels.Service;
using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Magazynuj.UI.ViewModels
{
    public class AddGoodsViewModel : OneViewModel<Commodity>
    {

        #region Constructor
        public AddGoodsViewModel()
        {
            item = new Commodity();

        }
        #endregion

        #region Properties
        public string Code
        {
            get { return item.Code; }
            set { if (value != item.Code) item.Code = value; base.OnPropertyChanged(() => Code); }
        }
        public string Name
        {
            get { return item.NameCommodity; }
            set { if (value != item.NameCommodity) item.NameCommodity = value; base.OnPropertyChanged(() => Name); }
        }
        public string Jm
        {
            get { return item.Jm; }
            set { if (value != item.Jm) item.Jm = value; base.OnPropertyChanged(() => Jm); }
        }
        public string RateVat
        {
            get { return item.RateVat; }
            set { if (value != item.RateVat) item.RateVat = value; base.OnPropertyChanged(() => RateVat); }
        }
        public decimal PriceB
        {
            get { return item.PriceB; }
            set { if (value != item.PriceB) item.PriceB = value; base.OnPropertyChanged(() => PriceB); PriceBChanged(value); }
        }
        public decimal PriceC
        {
            get { return item.PriceC; }
            set { if (value != item.PriceC) item.PriceC = value; base.OnPropertyChanged(() => PriceC); PriceCChanged(value); }
        }
        public decimal PriceA
        {
            get { return item.PriceA; }
            set { if (value != item.PriceA) item.PriceA = value; base.OnPropertyChanged(() => PriceA); PriceAChanged(value); }
        }
        public decimal PriceD
        {
            get { return item.PriceD; }
            set { if (value != item.PriceD) item.PriceD = value; base.OnPropertyChanged(() => PriceD); PriceDChanged(value); }
        }
        public decimal BruttoB
        {
            get { return item.BruttoB; }
            set { if (value != item.BruttoB) item.BruttoB = value; base.OnPropertyChanged(() => BruttoB); }
        }
        public decimal BruttoC
        {
            get { return item.BruttoC; }
            set { if (value != item.BruttoC) item.BruttoC = value; base.OnPropertyChanged(() => BruttoC); }
        }
        public decimal BruttoA
        {
            get { return item.BruttoA; }
            set { if (value != item.BruttoA) item.BruttoA = value; base.OnPropertyChanged(() => BruttoA); }
        }
        public decimal BruttoD
        {
            get { return item.BruttoD; }
            set { if (value != item.BruttoD) item.BruttoD = value; base.OnPropertyChanged(() => BruttoD); }
        }
        public string CodeEan
        {
            get { return item.CodeEan; }
            set { if (value != item.CodeEan) item.CodeEan = value; base.OnPropertyChanged(() => CodeEan); }
        }
        #endregion

        #region Helpers 
        public override void Save()
        {
            using (var context = new WarehouseManagementContext())
            {
                var commodity = new Commodity()
                {
                    Id = Guid.NewGuid(),

                };
                context.Commodity.Add(commodity);
                context.SaveChanges();

            }
            //warehouseManagementContext.Commodity.AddAsync(item);
            //warehouseManagementContext.SaveChangesAsync();
        }
        #endregion
        #region BruttoAChanged

        private void PriceAChanged(decimal val)
        {
            BruttoA = Convert.ToDecimal(Convert.ToDouble(val) * 1.23);
        }
        private void PriceBChanged(decimal val)
        {
            BruttoB = Convert.ToDecimal(Convert.ToDouble(val) * 1.23);
        }
        private void PriceCChanged(decimal val)
        {
            BruttoC = Convert.ToDecimal(Convert.ToDouble(val) * 1.23);
        }
        private void PriceDChanged(decimal val)
        {
            BruttoD = Convert.ToDecimal(Convert.ToDouble(val) * 1.23);
        }



        #endregion
    }
}
