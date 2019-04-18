using System;

namespace Selection_4.ConstructorAndInherExam
{
    public class Vehicle
    {
        private readonly string _regisNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string regisNumber)
        {
            _regisNumber = regisNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", regisNumber);
        }
    }
}

