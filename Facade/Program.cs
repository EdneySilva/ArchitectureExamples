using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args) 
        {
            var itens = Process.GetProcessesByName("Facade");
            Console.WriteLine(itens.FirstOrDefault()?.ProcessName ?? "not founded");
            Console.ReadKey();
            return;
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.LiberarEmprestimo();

        }
        
    }
}
