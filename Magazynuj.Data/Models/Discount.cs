﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class Discount
    {
        public Discount()
        {
            ContractorDetail = new HashSet<ContractorDetail>();
            Invoice = new HashSet<Invoice>();
        }

        [Column("percentage")]
        public int? Percentage { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("discountType_id")]
        public Guid? DiscountTypeId { get; set; }
        [Column("clientType_id")]
        public Guid? ClientTypeId { get; set; }

        [ForeignKey("ClientTypeId")]
        [InverseProperty("Discount")]
        public virtual ClientType ClientType { get; set; }
        [ForeignKey("DiscountTypeId")]
        [InverseProperty("Discount")]
        public virtual DiscountType DiscountType { get; set; }
        [InverseProperty("Discount")]
        public virtual ICollection<ContractorDetail> ContractorDetail { get; set; }
        [InverseProperty("Discount")]
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}