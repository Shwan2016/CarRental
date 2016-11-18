using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public byte DurationInMonth { get; set; }
        public short SignUpFee { get; set; }
        public byte DiscountRate { get; set; }  
    }
}