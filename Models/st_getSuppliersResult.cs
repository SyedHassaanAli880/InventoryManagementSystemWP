﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class st_getSuppliersResult
    {
        public long ID { get; set; }
        public string Name { get; set; }
        [Column("Person Name")]
        public string PersonName { get; set; }
        [Column("Phone 1")]
        public string Phone1 { get; set; }
        [Column("Phone 2")]
        public string Phone2 { get; set; }
        public string Address { get; set; }
        [Column("NTN#")]
        public string NTN { get; set; }
        public string Status { get; set; }
    }
}
