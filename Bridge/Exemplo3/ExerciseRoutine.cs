using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Exemplo3
{
    /// <summary>
    /// Esta é a abstração que pode varia, e contém a ponte (interface) para as implementações
    /// </summary>
    abstract class ExerciseRoutine
    {
        protected IRunner Runner { get; set; }
        public abstract void Workout();
    }
}
