using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPeople
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        //
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        //
        [Required]
        public int Age { get; set; }
    }
}
