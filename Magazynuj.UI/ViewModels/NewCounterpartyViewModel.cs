using Magazynuj.Data.Data;
using Magazynuj.Data.Models;
using Magazynuj.UI.ViewModels.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.UI.ViewModels
{
    public class NewCounterpartyViewModel : OneViewModel<Contractor>
    {
        private Adres adres;
        private PersonalData personalData;
        private Bank bank;
        private DefaultPriceList? defaultprice;
        public List<DefaultPaymentMethod> PaymentMethod { get; }
        public List<Discount> Discounts { get; }
        public List<DefaultPriceList> DefaultPriceList { get; }
        //public List<Adres> address { get; set; }
        //public List<PersonalData> personalData { get; set; }
        //public List<Bank> bank { get; set; }

        #region Constructor
        public NewCounterpartyViewModel()
        {
            item = new Contractor();
            adres = new Adres();
            personalData = new PersonalData();
            bank = new Bank();
            PaymentMethod = (from paymentMethods in warehouseManagementContext.DefaultPaymentMethod
                             select paymentMethods).ToList();
            Discounts = (from discount in warehouseManagementContext.Discount
                         select discount).ToList();
            DefaultPriceList = (from defaultPrice in warehouseManagementContext.DefaultPriceList
                                select defaultPrice).ToList();
        }
        #endregion

        #region Properties
        public string Code
        {
            get { return item.CodeContractor; }
            set { if (value != item.CodeContractor) item.CodeContractor = value; base.OnPropertyChanged(() => Code); }
        }
        public string Name
        {
            get { return item.NameContractor; }
            set { if (value != item.NameContractor) item.NameContractor = value; base.OnPropertyChanged(() => Name); }
        }
        public int HouseNumber
        {
            get { return adres.HouseNumber; }
            set { if (value != adres.HouseNumber) adres.HouseNumber = value; base.OnPropertyChanged(() => HouseNumber); }
        }
        public string? Street
        {
            get { return adres.Street; }
            set { if (value != adres.Street) adres.Street = value; base.OnPropertyChanged(() => Street); }
        }
        public string? PostalCode
        {
            get { return adres.PostalCode; }
            set { if (value != adres.PostalCode) adres.PostalCode = value; base.OnPropertyChanged(() => PostalCode); }
        }
        public string? City
        {
            get { return adres.City; }
            set { if (value != adres.City) adres.City = value; base.OnPropertyChanged(() => City); }
        }
        public string NIP
        {
            get { return personalData.Nip; }
            set { if (value != personalData.Nip) personalData.Nip = value; base.OnPropertyChanged(() => NIP); }
        }
        public string Regon
        {
            get { return personalData.Regon; }
            set { if (value != personalData.Regon) personalData.Regon = value; base.OnPropertyChanged(() => Regon); }
        }
        public string Krs
        {
            get { return personalData.Krs; }
            set { if (value != personalData.Krs) personalData.Krs = value; base.OnPropertyChanged(() => Krs); }
        }
        public string Pesel
        {
            get { return personalData.Pesel; }
            set { if (value != personalData.Pesel) personalData.Pesel = value; base.OnPropertyChanged(() => Pesel); }
        }
        public string IdNumber
        {
            get { return personalData.IdNumber; }
            set { if (value != personalData.IdNumber) personalData.IdNumber = value; base.OnPropertyChanged(() => IdNumber); }
        }
        public string FirstName
        {
            get { return personalData.FirstName; }
            set { if (value != personalData.FirstName) personalData.FirstName = value; base.OnPropertyChanged(() => FirstName); }
        }
        public string PhoneNumber
        {
            get { return personalData.PhoneNumber; }
            set { if (value != personalData.PhoneNumber) personalData.PhoneNumber = value; base.OnPropertyChanged(() => PhoneNumber); }
        }
        public string NameBank
        {
            get { return bank.NameBank; }
            set { if (value != bank.NameBank) bank.NameBank = value; base.OnPropertyChanged(() => NameBank); }
        }
        public string AccountNumber
        {
            get { return bank.AccountNumber; }
            set { if (value != bank.AccountNumber) bank.AccountNumber = value; base.OnPropertyChanged(() => AccountNumber); }
        }
        public string Email
        {
            get { return personalData.Email; }
            set { if (value != personalData.Email) personalData.Email = value; base.OnPropertyChanged(() => Email); }
        }
        public Guid? DefaultPaymentMethod
        {
            get { return item?.ContractorDetail?.DefaultPaymentMethodId; }
            set { if (value != item.ContractorDetail.DefaultPaymentMethodId) item.ContractorDetail.DefaultPaymentMethodId = value; base.OnPropertyChanged(() => DefaultPaymentMethod); }
        }
        public Guid? Discount
        {
            get { return item?.ContractorDetail?.DiscountId; }
            set { if (value != item.ContractorDetail.DiscountId) item.ContractorDetail.DiscountId = value; base.OnPropertyChanged(() => Discount); }
        }
        public DefaultPriceList? DefaultPrice
        {
            get { return defaultprice; }
            set { defaultprice = value; base.OnPropertyChanged(() => DefaultPrice); }
        }

        #endregion
        #region Helpers 
        public override void Save()
        {
            Adres adres = new Adres()
            {
                Id = Guid.NewGuid(),
                HouseNumber = this.HouseNumber,
                Street = this.Street,
                PostalCode = this.PostalCode,
                City = this.City,
            };
            Bank bank = new Bank()
            {
                Id = Guid.NewGuid(),
                AccountNumber = this.AccountNumber,
                NameBank = this.NameBank,
                AdresId = adres.Id,
                IsActive = true,
                IsForeign = null,
                Swift = null,
            };
            ContractorDetail contractorDetail = new ContractorDetail()
            {
                Id = Guid.NewGuid(),
                BankId = bank.Id,
                DefaultPaymentMethodId = DefaultPaymentMethod,
                DefaultPriceListId = DefaultPrice?.Id,
                DiscountId = Discount,
                IsRecipient = true,
                IsSupplier = true
            };
            PersonalData personalData = new PersonalData()
            {
                Id = Guid.NewGuid(),
                Nip = this.NIP,
                Regon = this.Regon,
                Krs = this.Krs,
                Pesel = this.Pesel,
                IdNumber = this.IdNumber,
                FirstName = this.FirstName,
                PhoneNumber = this.PhoneNumber,
                DateBirth = null,
                AdresId = adres.Id,
                LastName = null,

            };
            using (var context = new WarehouseManagementContext())
            {
                context.Adres.Add(adres);

                context.Bank.Add(bank);
                context.ContractorDetail.Add(contractorDetail);
                context.PersonalData.Add(personalData);
                context.SaveChanges();
            }
            using (var context = new WarehouseManagementContext())
            {
                var contractor = new Contractor()
                {
                    Id = Guid.NewGuid(),
                    PersonalDataId = personalData.Id,
                    IsActive = true,
                    AuthorizedPersonId = personalData.Id,
                    AdresId = adres.Id,
                    ContractorDetailId = contractorDetail.Id,
                    CodeContractor = this.Code,
                    NameContractor = this.Name,

                };
                context.Contractor.Add(contractor);
                context.SaveChanges();

            }
        }
        #endregion
    }
}

