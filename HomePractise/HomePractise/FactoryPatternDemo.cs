using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractise
{
    class FactoryPatternDemo
    {
        public static void Main(String [] args)
        {
            ShapeFactory shapefactory = new ShapeFactory();

            Shape shape1 = shapefactory.getShape("Circle");
            shape1.draw();

            Shape shape2 = shapefactory.getShape("Square");
            shape2.draw();

            Shape shape3 = shapefactory.getShape("Rectangle");
            shape3.draw();

        }
    }
}
