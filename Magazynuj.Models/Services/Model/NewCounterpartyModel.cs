using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.Models.Services.Model
{
    public class NewCounterpartyModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? PersonalDataId { get; set; }
        public int? AdresId { get; set; }
        public int? ContractorDetailId { get; set; }
        public int? AuthorizedPersonId { get; set; }
        public string Name { get; set; }
        public string NamePaymentMethod { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string IdNumber { get; set; }
        public string Nip { get; set; }
        public string Regon { get; set; }
        public string Krs { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? Percentage { get; set; }
        public int? ClientTypeId { get; set; }
        public int? DiscountTypeId { get; set; }
    }
}
