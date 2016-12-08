using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPeople
{
    public class PeopleContext:Context
    {
        //public PeopleContext() : base("name=PeopleDBConnectionString")
        public PeopleContext() : base()
        {

        }

        public DBSet<Person> Persons { get; set; }

    }

}
