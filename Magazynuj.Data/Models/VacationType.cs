﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class VacationType
    {
        public VacationType()
        {
            VacationSchedule = new HashSet<VacationSchedule>();
        }

        [Column("name")]
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; }
        [Key]
        public Guid Id { get; set; }

        [InverseProperty("VacationType")]
        public virtual ICollection<VacationSchedule> VacationSchedule { get; set; }
    }
}