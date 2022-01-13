using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Entity
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        public int CId { get; set; }
        public int? ParentId { get; set; }
        public int? Position { get; set; }
        public string PrimaryColorCode { get; set; }
        public string ColorCode { get; set; }
        public string Name { get; set; }
        public string NameH { get; set; }
        public string Locale { get; set; }
    }
}
