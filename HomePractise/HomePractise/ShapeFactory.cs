using System;
using System.Collections.Generic;
using System.Text;

namespace HomePractise
{
    class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            if (shapeType.Equals("Circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("Square"))
            {
                return new Square();
            }
            else if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }

            return null;
        }
    }
}
