﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class st_getProductwrtBarcodeForSaleResult
    {
        [Column("Product ID")]
        public long ProductID { get; set; }
        public string Product { get; set; }
        [Column("Product Barcode")]
        public string ProductBarcode { get; set; }
        [Column("Selling Price")]
        public decimal? SellingPrice { get; set; }
        public decimal? Discount { get; set; }
        [Column("Final Selling Price")]
        public decimal? FinalSellingPrice { get; set; }
    }
}
