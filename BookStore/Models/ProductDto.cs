using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class ProductDto
    {
        [Required]
        [Key]
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int BusinessId { get; set; }
        public int TaxId { get; set; }
        public int SupplierId { get; set; }
        public string BarcodeId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public int Weight { get; set; }
        public string WeightUnit { get; set; }
        public double BusinessCost { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
