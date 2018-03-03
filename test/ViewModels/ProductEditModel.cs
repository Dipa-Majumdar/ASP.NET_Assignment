using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test.ViewModels
{
    public class ProductEditModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string type { get; set; }
    }
}
