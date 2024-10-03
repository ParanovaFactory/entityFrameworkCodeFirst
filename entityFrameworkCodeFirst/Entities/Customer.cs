using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkCodeFirst.Entities
{
    internal class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerCity { get; set; }
    }
}
