using System.Data.Entity;

namespace EFPeople
{
    public class Context:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}