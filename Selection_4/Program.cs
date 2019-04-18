using Amazon;
using Selection_4.ConstructorAndInherExam;
using Selection_4.UpCastingAndDownCastingExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Access Modifiers");
            var customer = new Customer();
            customer.Promote();
            Amazon.RateCalculator calculator = new RateCalculator();

            Console.WriteLine("==========================");
            Console.WriteLine("Example Constructor and Inheritance");
            var car = new Car("D19920ZTT");

            Console.WriteLine("==========================");
            Console.WriteLine("Example Up Casting And Down Casting");
            //Text text = new Text();
            //Shape shape = new Shape();
            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width);
            Shape shape = new Text();
            Text text = (Text)shape;


            Console.ReadKey();
        }
    }
}
