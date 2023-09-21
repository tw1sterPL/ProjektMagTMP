﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    [Table("shiftType")]
    public partial class ShiftType
    {
        public ShiftType()
        {
            ShiftSupervisor = new HashSet<ShiftSupervisor>();
        }

        [Column("name")]
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("shiftHours_id")]
        public Guid? ShiftHoursId { get; set; }

        [ForeignKey("ShiftHoursId")]
        [InverseProperty("ShiftType")]
        public virtual ShiftHours ShiftHours { get; set; }
        [InverseProperty("ShiftType")]
        public virtual ICollection<ShiftSupervisor> ShiftSupervisor { get; set; }
    }
}