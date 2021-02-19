using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PascanRares_Project.Models
{
    public class Laptop //Book
    {
        public int ID { get; set; }
        public string Brand_Name { get; set; } // Title
        public string Processor { get; set; } // Author
        [Column(TypeName = "decimal(6, 2)")]

        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
       


    }
}
