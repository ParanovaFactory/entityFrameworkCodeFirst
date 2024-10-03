using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkCodeFirst.Entities
{
    internal class Job
    {
        [Key]
        public int jobId { get; set; }
        public string jobName { get; set; }
    }
}
