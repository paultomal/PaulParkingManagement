using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ParkingSpot
    {
        [Key] 
        public string ParkingID { get; set;}
        [Required]
        public string Location { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int PriceParHour { get; set; }
        [Required]
        public int AvailableSpots { get; set; }

        [ForeignKey("ServiceProvider")]
        public string ProviderID { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }

        public ParkingSpot()
        {
            Reservations = new List<Reservation>();
        }



    }
}
