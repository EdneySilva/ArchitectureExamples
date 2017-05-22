using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Block questionario = new Block("Questionáro de entrevista");

            var blockA = new Block("Bloco A - Dados Gerais")
                .Add(new Question("1) Nome Completo:"))
                .Add(new Question("2) Data de Nascimento:"));

            var blockB = new Block("Bloco B - Habilidades");
            var blockB1 = new Block("Bloco B1 - Arquitetura")
                .Add(new Question("3) O que é SOLID?"));
            var blockB2 = new Block("Bloco B2 - Plataforma .NET")
                .Add(new Question("4) Qual o objetivo do namespace System.Linq?"));
            blockB.Add(blockB1)
                .Add(blockB2);

            questionario
                .Add(blockA)
                .Add(blockB)
                .Add(new Question("Observaçoes:"))
                .Show();

        }
    }
}