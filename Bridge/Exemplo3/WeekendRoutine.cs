using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Exemplo3
{
    /// <summary>
    /// Está é uma variação da abstração
    /// </summary>  
    class WeekendRoutine : ExerciseRoutine
    {
        public WeekendRoutine(IRunner implementacao)
        {
            Runner = implementacao;
        }

        public override void Workout()
        {
            Console.WriteLine("Exercicio para o fim de semana");
            Runner.Run();
        }
    }
}
