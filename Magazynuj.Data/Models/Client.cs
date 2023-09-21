﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class Client
    {
        public Client()
        {
            Invoice = new HashSet<Invoice>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("gender_id")]
        public Guid? GenderId { get; set; }
        [Column("maritalStatus_id")]
        public Guid? MaritalStatusId { get; set; }
        [Column("clientType_id")]
        public Guid? ClientTypeId { get; set; }
        [Column("personalData_id")]
        public Guid? PersonalDataId { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }

        [ForeignKey("ClientTypeId")]
        [InverseProperty("Client")]
        public virtual ClientType ClientType { get; set; }
        [ForeignKey("GenderId")]
        [InverseProperty("Client")]
        public virtual Gender Gender { get; set; }
        [ForeignKey("MaritalStatusId")]
        [InverseProperty("Client")]
        public virtual MaritalStatus MaritalStatus { get; set; }
        [ForeignKey("PersonalDataId")]
        [InverseProperty("Client")]
        public virtual PersonalData PersonalData { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}