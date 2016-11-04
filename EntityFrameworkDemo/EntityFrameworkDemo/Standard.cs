using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Standard
    {
        public Standard()
        {
            //Students = new List<Student>();

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        //public ICollection<Student> Students { get; set; }
    }
}
