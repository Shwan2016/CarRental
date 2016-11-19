using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public int TitleNumber { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public float Miles { get; set; }
        public int NumberInStock { get; set; }
        public CarModel CarModel { get; set; }
        public int CarModelId { get; set; }
    }
}
