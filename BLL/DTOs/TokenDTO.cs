using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public  class TokenDTO
    {
        public string TKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? Expired { get; set; }
        public string CustomerId { get; set; }
    }
}
