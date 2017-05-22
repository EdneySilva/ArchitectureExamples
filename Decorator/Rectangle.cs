using System;

namespace Decorator
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--                                     --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--  ---------------------------------  --");
            Console.WriteLine("--                                     --");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
        }
    }
}