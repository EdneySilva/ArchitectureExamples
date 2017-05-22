using System;

namespace Decorator
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            DecoratedShape.Draw();
        
        }
    }
}