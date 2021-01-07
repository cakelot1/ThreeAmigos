using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    

    public class Menu
    {
        public Menu() { }

        public Menu(String menuName)
        {
            MenuName = menuName;
        }

        [Required]
        public int MenuId { get; set; }

        public String MenuName { get; set; }

        public ICollection<MenuFoodItem> MenuFoodItems { get; set; }
    }
}
