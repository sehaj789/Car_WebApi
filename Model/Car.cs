using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Car.Model
{
    public class Car
    {
        public string Id { get; set; }
        [Required ]
        public int Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public decimal Price { get; set; }



    }
}
