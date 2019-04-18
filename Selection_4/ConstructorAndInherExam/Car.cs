using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_4.ConstructorAndInherExam
{
    public class Car : Vehicle
    {
        public Car(string regisNumber)
            : base(regisNumber)
        {
            Console.WriteLine("Car is being initialized {0}", regisNumber);
        }
    }
}
