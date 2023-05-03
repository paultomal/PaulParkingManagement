using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceProviderDTOs
{
    public class ParkingSpotSPDTO
    {
        public string ParkingID { get; set; }
        [Required]
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int PriceParHour { get; set; }
        public int AvailableSpots { get; set; }
        public string ProviderID { get; set; }
    }
}
