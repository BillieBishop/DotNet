using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;//needed for Foreign Key
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class StudentAddress
    {
        // [ForeignKey("Student")]
        public int StudentAddressId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        //public virtual Student Student { get; set; }
    }
}
