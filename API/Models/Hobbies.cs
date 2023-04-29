using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy.Models
{
    public class Hobbies
    {
        [Key]
        public int id { get; set; }
        public string state { get; set; }
    }
}
