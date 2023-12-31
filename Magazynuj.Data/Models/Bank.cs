﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Company = new HashSet<Company>();
            ContractorDetail = new HashSet<ContractorDetail>();
            Invoice = new HashSet<Invoice>();
        }

        [Column("nameBank")]
        [StringLength(255)]
        [Unicode(false)]
        public string NameBank { get; set; }
        [Column("accountNumber")]
        [StringLength(26)]
        [Unicode(false)]
        public string AccountNumber { get; set; }
        [Column("isForeign")]
        public int? IsForeign { get; set; }
        [Column("swift")]
        [StringLength(8)]
        [Unicode(false)]
        public string Swift { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("adres_id")]
        public Guid? AdresId { get; set; }
        [Column("isActive")]
        public bool IsActive { get; set; }

        [ForeignKey("AdresId")]
        [InverseProperty("Bank")]
        public virtual Adres Adres { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<Company> Company { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<ContractorDetail> ContractorDetail { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}