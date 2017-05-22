using System;

namespace Bridge.Exemplo1
{

    interface IDrawApi
    {
        void DrawCircle(int radius, int x, int y);
    }
    class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Draw a Circle[color: red, radius: {radius}, x: {x}, y: {y}");
        }
    }

    class GreenCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Draw a Circle[color: green, radius: {radius}, x: {x}, y: {y}");
        }
    }
}