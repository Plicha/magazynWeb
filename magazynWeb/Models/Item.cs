using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace magazynWeb.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}