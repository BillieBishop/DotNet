using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PeopleContext())
            {
                Person person = new Person() { Name = "New Person" };

                context.Persons.Add(person);
                context.SaveChanges();
            }
        }
    }
}
