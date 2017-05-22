using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Exemplo2
{
    interface IDeviceApi
    {
        void On();
        void Off();
        string[] GetCommands();
        void RunCommand(string comando);
    }

    class Camera : IDeviceApi
    {
        public void On()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Camera ligada");
        }

        public string[] GetCommands()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return new string[]
            {
                "Tirar Foto",
                "Filmar"
            };
        }

        public void RunCommand(string comando)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Comando Executado: " + comando);
        }

        public void Off()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Camera desligada");
        }
    }

    class Impressora : IDeviceApi
    {
        public void On()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Impressora ligada");
        }

        public string[] GetCommands()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return new string[]
            {
                "Imprimir",
                "Scanear"
            };
        }

        public void RunCommand(string comando)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Comando Executado: " + comando);
        }

        public void Off()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Impressora desligada");
        }
    }
}
