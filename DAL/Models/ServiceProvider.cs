using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ServiceProvider
    {
        [Key]
        public string ProviderID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Review> Reviews { get; set; } 
        public virtual ICollection<ParkingSpot> ParkingSpots { get; set; } 
        public virtual ICollection<Payment> Payments { get; set; } 

        public ServiceProvider() 
        {
            ParkingSpots = new List<ParkingSpot>();
            Payments = new List<Payment>();
            Reviews = new List<Review>();


        }





    }
}
