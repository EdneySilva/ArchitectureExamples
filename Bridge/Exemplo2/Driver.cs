using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Exemplo2
{
    abstract class Driver
    {
        protected IDeviceApi Device { get; set; }
        protected Driver(IDeviceApi device)
        {
            this.Device = device;
        }

        public abstract Driver Configure();
        public abstract void Trigger(string command);
    }

    class DriverGenerico : Driver
    {
        public DriverGenerico(IDeviceApi device) : base(device)
        {
        }
        public override Driver Configure()
        {
            this.Device.On();
            Console.WriteLine(this.Device.GetCommands().Aggregate((seed, item) => seed += "\n" + item));
            return this;
        }

        public override void Trigger(string command)
        {
            this.Device.RunCommand(command);
            this.Device.Off();
        }
    }
}
