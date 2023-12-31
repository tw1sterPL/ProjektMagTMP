﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class ContractorDetail
    {
        public ContractorDetail()
        {
            Contractor = new HashSet<Contractor>();
        }

        [Column("isRecipient")]
        public bool? IsRecipient { get; set; }
        [Column("isSupplier")]
        public bool? IsSupplier { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("defaultPaymentMethod_id")]
        public Guid? DefaultPaymentMethodId { get; set; }
        [Column("discount_id")]
        public Guid? DiscountId { get; set; }
        [Column("defaultPriceList_id")]
        public Guid? DefaultPriceListId { get; set; }
        [Column("bank_id")]
        public Guid? BankId { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("ContractorDetail")]
        public virtual Bank Bank { get; set; }
        [ForeignKey("DefaultPaymentMethodId")]
        [InverseProperty("ContractorDetail")]
        public virtual DefaultPaymentMethod DefaultPaymentMethod { get; set; }
        [ForeignKey("DefaultPriceListId")]
        [InverseProperty("ContractorDetail")]
        public virtual DefaultPriceList DefaultPriceList { get; set; }
        [ForeignKey("DiscountId")]
        [InverseProperty("ContractorDetail")]
        public virtual Discount Discount { get; set; }
        [InverseProperty("ContractorDetail")]
        public virtual ICollection<Contractor> Contractor { get; set; }
    }
}