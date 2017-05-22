using System;

namespace Decorator
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----------------          ---------------");
            Console.WriteLine("-------------  ------------  ------------");
            Console.WriteLine("-----------  ---------------  -----------");
            Console.WriteLine("----------  -----------------  ----------");
            Console.WriteLine("---------  -------------------  ---------");
            Console.WriteLine("---------  -------------------  ---------");
            Console.WriteLine("---------  -------------------  ---------");
            Console.WriteLine("----------  -----------------  ----------");
            Console.WriteLine("------------  --------------  -----------");
            Console.WriteLine("--------------  ----------  -------------");
            Console.WriteLine("----------------          ---------------");
            Console.WriteLine("-----------------------------------------");
        }
    }
}