using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new UniContextEntities())
            {
                var query = from b in db.Employee1 orderby b.ID select b;
                Console.WriteLine("All students in database ");
                foreach (var employee in query)
                {
                    Console.WriteLine(employee.Name + "        " + employee.PhoneNumber);
                }
                Console.WriteLine("press any key to exit");
                Console.ReadKey();


            }
            // The code provided will print ‘Hello World’ to the console.
           
        }
    }
}
