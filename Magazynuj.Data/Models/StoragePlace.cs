﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magazynuj.Data.Models
{
    public partial class StoragePlace
    {
        public StoragePlace()
        {
            CommodityDetails = new HashSet<CommodityDetails>();
        }

        [Column("placeNumber")]
        [StringLength(255)]
        [Unicode(false)]
        public string PlaceNumber { get; set; }
        [Key]
        public Guid Id { get; set; }
        [Column("warehouse_id")]
        public Guid? WarehouseId { get; set; }

        [ForeignKey("WarehouseId")]
        [InverseProperty("StoragePlace")]
        public virtual Warehouse Warehouse { get; set; }
        [InverseProperty("StoragePlace")]
        public virtual ICollection<CommodityDetails> CommodityDetails { get; set; }
    }
}