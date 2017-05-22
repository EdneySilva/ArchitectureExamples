using System;

namespace Decorator
{
    abstract class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape { get; set; }

        public ShapeDecorator(IShape decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            DecoratedShape.Draw();
        }
    }
}