using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ServiceProviderDTOs
{
    public class SpotPaymentDTO :ParkingSpotSPDTO
    {
        public List<PaymentSPDTO> Reviews { get; set; }
        public SpotPaymentDTO()
        {
            Reviews = new List<PaymentSPDTO>();
        }
    }
}
