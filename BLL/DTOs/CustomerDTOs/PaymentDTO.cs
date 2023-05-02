using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.CustomerDTOs
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentAmount { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public string ProviderID { get; set; }
        [Required]
        public string ReservationID { get; set; }
    }
}
