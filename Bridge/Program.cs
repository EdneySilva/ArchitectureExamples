using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// http://stackoverflow.com/questions/5863530/strategy-vs-bridge-patterns
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            

            Exemplo1.Shape redCircle = new Exemplo1.Circle(100, 100, 10, new Exemplo1.RedCircle());
            Exemplo1.Shape greenCircle = new Exemplo1.Circle(100, 100, 10, new Exemplo1.GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Exemplo2.Driver driverCamera = new Exemplo2.DriverGenerico(new Exemplo2.Camera());
            Exemplo2.Driver driverImpressora = new Exemplo2.DriverGenerico(new Exemplo2.Impressora());

            driverCamera.Configure().Trigger("Tirar Foto");

            driverImpressora.Configure().Trigger("Imprimir");

            Exemplo3.ExerciseRoutine rotinaDeExercicios = new Exemplo3.WeekdayRoutine(new Exemplo3.Park());
            rotinaDeExercicios.Workout();

            rotinaDeExercicios = new Exemplo3.WeekendRoutine(new Exemplo3.SideWalk());
            rotinaDeExercicios.Workout();


        }
    }
    
}
