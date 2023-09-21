﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class PersonalData
    {
        public PersonalData()
        {
            Client = new HashSet<Client>();
            Contractor = new HashSet<Contractor>();
            Employee = new HashSet<Employee>();
        }

        [Column("firstName")]
        [StringLength(255)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        [Unicode(false)]
        public string LastName { get; set; }
        [Column("dateBirth", TypeName = "datetime")]
        public DateTime? DateBirth { get; set; }
        [Column("pesel")]
        [StringLength(11)]
        [Unicode(false)]
        public string Pesel { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string IdNumber { get; set; }
        [Column("nip")]
        [StringLength(10)]
        [Unicode(false)]
        public string Nip { get; set; }
        [Column("regon")]
        [StringLength(9)]
        [Unicode(false)]
        public string Regon { get; set; }
        [Column("krs")]
        [StringLength(10)]
        [Unicode(false)]
        public string Krs { get; set; }
        [Column("phoneNumber")]
        [StringLength(12)]
        [Unicode(false)]
        public string PhoneNumber { get; set; }
        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("adres_id")]
        public Guid? AdresId { get; set; }

        [ForeignKey("AdresId")]
        [InverseProperty("PersonalData")]
        public virtual Adres Adres { get; set; }
        [InverseProperty("PersonalData")]
        public virtual ICollection<Client> Client { get; set; }
        [InverseProperty("PersonalData")]
        public virtual ICollection<Contractor> Contractor { get; set; }
        [InverseProperty("PersonalData")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}