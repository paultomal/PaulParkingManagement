using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceProviderDTOs
{
    public class SpotReservationDTO : ParkingSpotSPDTO
    {
        public List<ReservationSPDTO> Reviews { get; set; }
        public SpotReservationDTO()
        {
            Reviews = new List<ReservationSPDTO>();
        }
    }
}
