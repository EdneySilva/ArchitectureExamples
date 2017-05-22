using System;

namespace Bridge.Exemplo1
{
    abstract class Shape
    {
        protected IDrawApi Drawer { get; set; }

        protected Shape(IDrawApi drawApi)
        {
            this.Drawer = drawApi;
        }

        public abstract void Draw();

    }

    class Circle : Shape
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Radius { get; set; }

        public Circle(int x, int y, int radius, IDrawApi drawApi) : base(drawApi)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;    
        }

        public override void Draw()
        {
            this.Drawer.DrawCircle(Radius, X, Y);
        }
    }
}