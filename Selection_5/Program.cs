using Selection_5.AbsractExam;
using Selection_5.MethodOverridingExam;
using System;
using System.Collections.Generic;

namespace Selection_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Overriding Method Example");
                var shapes = new List<Shape>();
                shapes.Add(new Circle());
                shapes.Add(new Rectangle());
                shapes.Add(new Triangle());

                var canvas = new Canvas();
                canvas.DrawShapes(shapes);

                Console.WriteLine("=================");
                Console.WriteLine("Abstract Class Example");
                var circle = new Circles();
                circle.Draw();

                var rectangle = new Rectangles();
                rectangle.Draw();
            }
        }
    }
}
