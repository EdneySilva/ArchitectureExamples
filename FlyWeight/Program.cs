using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomKey custom = new CustomKey();
            CustomKey custom2 = new CustomKey("Nome");
            CustomKey custom3 = new CustomKey("Nome", "Idade");
            CustomKey custom5 = new CustomKey("Nome", "Idade");
            CustomKey custom4 = new CustomKey("Idade", "Nome");
            CustomKey custom6 = new CustomKey("Idade");
            Console.ReadKey();
        }
    }
}
