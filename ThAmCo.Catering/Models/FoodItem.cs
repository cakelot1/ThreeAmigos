using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodItem
    {
        public FoodItem() { }

        public FoodItem(String description, int unitPrice){
            Description = description;
            UnitPrice = unitPrice;
        }

        [Required]
        public int FoodItemId { get; set; }

        public String Description { get; set; }

        public float UnitPrice { get; set; }
    }
}
