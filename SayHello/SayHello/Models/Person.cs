using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SayHello.Models
{
    public class Person
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Range(0, 130)]
        public int Age { get; set; }

        [RegularExpression(@"^[A-Z][0-9][A-Z] ?[0-9][A-Z][0-9]$")]
        public string PostalCode { get; set; }
    }
}