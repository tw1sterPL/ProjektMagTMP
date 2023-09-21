using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.Models.Services.ForViews
{
    public class CounterPartyForAllView
    {
        #region Properies
        public string? ContractorCode { get; set; }
        public string? ContractorName { get; set; }
        public string? AdresCity { get; set; }
        public string? AdresStreet { get; set; }
        public int? AdresHouseNumber { get; set; }
        public string NIP { get; set; }
        #endregion
    }
}
