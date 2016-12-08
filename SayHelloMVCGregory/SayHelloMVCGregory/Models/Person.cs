using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SayHelloMVCGregory.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Range(5,50)]
        public int Age { get; set; }
    }
}