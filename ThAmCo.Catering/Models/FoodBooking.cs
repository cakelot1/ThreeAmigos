using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodBooking
    {

        public FoodBooking() { }

        public FoodBooking(int clientReference, int numberOfGuests, int menuId) {
            ClientReference = clientReference;
            NumberOfGuests = numberOfGuests;
            MenuId = menuId;
        }

        [Required]
        public int FoodBookingId { get; set; }

        public int ClientReference { get; set; }

        public int NumberOfGuests { get; set; }

        public int? MenuId { get; set; }

        public Menu Menu { get; set; }

    }
}
