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
    class WeekdayRoutine : ExerciseRoutine
    {
        public WeekdayRoutine(IRunner implementacao)
        {
            this.Runner = implementacao;
        }

        public override void Workout()
        {
            Console.WriteLine("Tarefas da semana");
            Runner.Run();
        }
    }
}
