using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.DTOs.ServiceProviderDTOs
{
    public class SpotReviewDTO : ParkingSpotSPDTO
    {
        public List<ReviewSPDTO> Reviews { get; set; }
        public SpotReviewDTO()
        {
            Reviews = new List<ReviewSPDTO>();
        }
    }
}
