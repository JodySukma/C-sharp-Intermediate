using Selection_2.AccesModifiersExam;
using Selection_2.ConstructorExam;
using Selection_2.FieldExam;
using Selection_2.Indexs;
using Selection_2.MethodExam;
using Selection_2.PropertiesExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Class");
            var person = Person.Parse("Iwan");
            person.Introduce("Jody Sukma Atmadja");

            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Jody";

            Console.WriteLine("====================");
            Console.WriteLine("Example Construcktor");
            var order = new Order();
            customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine("====================");
            Console.WriteLine("Example Method");
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Concersion failed.");

            Console.WriteLine("====================");
            Console.WriteLine("Example Field");
            var cust = new Pelanggan(1);
            cust.Orders.Add(new Mesan());
            cust.Orders.Add(new Mesan());
            cust.Promote();

            Console.WriteLine(cust.Orders.Count);

            Console.WriteLine("====================");
            Console.WriteLine("Example Access Modifiers");
            var orang = new Orang();
            orang.SetBirthDate(new DateTime(1995, 1, 24));
            Console.WriteLine(orang.GetBirthDate());

            Console.WriteLine("====================");
            Console.WriteLine("Example Properties");
            var jelema = new Jelema(new DateTime(1995, 1, 24));
            Console.WriteLine(jelema.Age);

            Console.WriteLine("====================");
            Console.WriteLine("Example Index");
            var cookie = new HttpCookie();
            cookie["name"] = "Jody";
            Console.WriteLine(cookie["name"]);

            Console.ReadKey();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int [] { 1, 2, 3, 4, 5 } ));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
