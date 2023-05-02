using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Reservation
    {
        [Key]
        public string ReservationID { get; set; }
       
        [Required]
        [StringLength(100)]
        public string CheckInDateTime { get; set; }
       
        [Required]
        [StringLength(100)]
        public string CheckOutDateTime { get; set; }
 
        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("ParkingSpot")]
        public string ParkingID { get; set; }
        public virtual ParkingSpot ParkingSpot { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public Reservation()
        {
            Payments = new List<Payment>();
        }

    }
}
