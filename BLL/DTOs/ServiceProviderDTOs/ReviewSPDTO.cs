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
    public class ReviewSPDTO
    {
        public string ReviewID { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        public string CustomerID { get; set; }
        public string ProviderID { get; set; }
    }
}
