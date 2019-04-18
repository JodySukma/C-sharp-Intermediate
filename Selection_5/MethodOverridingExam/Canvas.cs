using System.Collections.Generic;
using System;

namespace Selection_5.MethodOverridingExam
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
                //switch (shape.type)
                //{
                //    case ShapeType.Circle:
                       
                //        break;

                //    case ShapeType.Rectangle:
                //        Console.WriteLine("Draw a rectangle");
                //        break;

                //    case ShapeType.Triangle:
                //        Console.WriteLine("Draw a triangle");
                //        break;
                //}
            }
        }
    }
   
}
