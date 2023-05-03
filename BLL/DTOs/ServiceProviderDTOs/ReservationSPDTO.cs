using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceProviderDTOs
{
    public class ReservationSPDTO
    {
        public string ReservationID { get; set; }
        [Required]
        public string CheckInDateTime { get; set; }
        [Required]
        public string CheckOutDateTime { get; set; }
        public string CustomerID { get; set; }
        public string ParkingID { get; set; }
    }
}
