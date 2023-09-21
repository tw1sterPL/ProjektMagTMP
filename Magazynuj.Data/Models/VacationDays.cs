﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class VacationDays
    {
        [Column("numberOfVacationDays")]
        [StringLength(30)]
        [Unicode(false)]
        public string NumberOfVacationDays { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("employee_id")]
        public Guid? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("VacationDays")]
        public virtual Employee Employee { get; set; }
    }
}