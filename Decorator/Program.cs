using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            Console.WriteLine("Exibindo Circulo");
            circle.Draw();

            Console.WriteLine(string.Empty);
            Console.WriteLine("Exibindo Retangulo");
            rectangle.Draw();

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine("Adicionando funcionalidade de alteração de cores aos shapes");
            ShapeDecorator decoratedCircle = new RedShapeDecorator(circle);
            ShapeDecorator decoratedRectangle = new RedShapeDecorator(rectangle);
            Console.WriteLine("Exibindo Circulo");
            decoratedCircle.Draw();

            Console.WriteLine(string.Empty);
            Console.WriteLine("Exibindo Retangulo");
            decoratedRectangle.Draw();
        }
    }
}
