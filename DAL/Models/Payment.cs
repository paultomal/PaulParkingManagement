using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentAmount { get; set; }



        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("ServiceProvider")]
        public string ProviderID { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
        
        [ForeignKey("Reservation")]
        public string ReservationID { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}
