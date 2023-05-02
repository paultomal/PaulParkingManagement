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
    public class ReviewDTO
    {
        public string ReviewID { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public string ProviderID { get; set; }
    }
}
