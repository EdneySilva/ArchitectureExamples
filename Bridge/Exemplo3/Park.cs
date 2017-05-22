using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Exemplo3
{

    /// <summary>
    /// Esta é uma variação da implementação que realiza todo o trabalho
    /// </summary>
    class Park : IRunner
    {
        public void Run()
        {
            Console.WriteLine("Correndo no parque");
        }
    }
}
