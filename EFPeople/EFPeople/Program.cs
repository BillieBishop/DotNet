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
            while (true)
            {
                string choice = AskForInput();
                try
                {
                    using (var ctx = new Context())
                    {

                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter person name : ");
                                string name = Console.ReadLine();
                                Console.Write("Enter person age : ");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Person personToInsert = new Person { Name = name, Age = age };
                                ctx.Persons.Add(personToInsert);
                                ctx.SaveChanges();
                                Console.WriteLine("{0} of age {1} was added to the database.", name, age);
                                break;
                            case "2":
                                foreach (var person in ctx.Persons)
                                {
                                    Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", person.ID, person.Name, person.Age);
                                }
                                break;
                            case "3":
                                Console.Write("Enter person id to delete : ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Person personToDelete = ctx.Persons.Find(id);
                                ctx.Persons.Remove(personToDelete);
                                ctx.SaveChanges();
                                break;
                            case "4":
                                Console.Write("Enter person id to update : ");
                                int identity = Convert.ToInt32(Console.ReadLine());
                                Person personToUpdate = ctx.Persons.Find(identity);
                                Console.Write("Enter person new name : ");
                                personToUpdate.Name = Console.ReadLine();
                                Console.Write("Enter person new age : ");
                                personToUpdate.Age = Convert.ToInt32(Console.ReadLine()); 
                                ctx.SaveChanges();
                                Console.WriteLine("{0} of age {1} was updated to the database.", personToUpdate.Name, personToUpdate.Age);
                                break;
                            case "0":
                                Console.WriteLine("Are you sure you want to exit application? Enter Y/N");
                                string answer = Console.ReadLine();
                                switch (answer)
                                {
                                    case "y":
                                    case "Y":
                                        Environment.Exit(0);
                                        break;
                                    case "n":
                                    case "N":
                                    default:
                                        return;
                                }
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.Write("Database Error");
                    Console.ReadKey();
                    throw new Exception();
                }
            }
        }

        private static string AskForInput()
        {
            Console.WriteLine("Please Choose an Option: \n -------------------------------------");
            Console.WriteLine(" 1. Add Person \n 2. List people \n 3. Delete Person by ID \n 4. Update Person by ID \n 0. Exit");

            string choice = Console.ReadLine();
            return choice;
        }
    }
}
