using Magazynuj.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.UI.ViewModels
{
    public class LoginScreenViewModel
    {
        public WarehouseManagementContext warehouseManagementContext { get; set; }

        public LoginScreenViewModel()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
