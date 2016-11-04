using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        /*
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        string path = (System.IO.Path.GetDirectoryName(executable));
        AppDomain.CurrentDomain.SetData("DataDirectory", path);
        } */

    static void Main(string[] args)
        {

        AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

        using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "New Student" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                //Console.WriteLine(ctx.Database.Connection.DataSource);
                //Console.ReadKey();
            }
        }
    }
}
