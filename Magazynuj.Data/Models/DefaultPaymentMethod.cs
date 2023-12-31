﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class DefaultPaymentMethod
    {
        public DefaultPaymentMethod()
        {
            ContractorDetail = new HashSet<ContractorDetail>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("namePaymentMethod")]
        [StringLength(255)]
        [Unicode(false)]
        public string NamePaymentMethod { get; set; }

        [InverseProperty("DefaultPaymentMethod")]
        public virtual ICollection<ContractorDetail> ContractorDetail { get; set; }
    }
}