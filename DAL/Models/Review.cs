using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Review
    {
        [Key]
        public string ReviewID { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Comment { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("ServiceProvider")]
        public string ProviderID { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}
