﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class ShiftHours
    {
        public ShiftHours()
        {
            ShiftType = new HashSet<ShiftType>();
        }

        [Column("startHour", TypeName = "datetime")]
        public DateTime? StartHour { get; set; }
        [Column("endHour", TypeName = "datetime")]
        public DateTime? EndHour { get; set; }
        [Key]
        public Guid Id { get; set; }

        [InverseProperty("ShiftHours")]
        public virtual ICollection<ShiftType> ShiftType { get; set; }
    }
}