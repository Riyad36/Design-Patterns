using System.Transactions;

namespace DecoratorPattern
{
    public class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public void draw()
        {
            decoratedShape.draw();
        }
    }
}
