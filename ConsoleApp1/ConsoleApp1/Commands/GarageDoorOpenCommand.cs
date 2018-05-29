using ConsoleApp1.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class GarageDoorOpenCommand : iCommand
    {
        GarageDoor garageDoor = null;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Stop();
            garageDoor.On();
            garageDoor.LightOn();
        }

        public void Undo()
        {
            garageDoor.Stop();
            garageDoor.Off();
            garageDoor.LightOff();
        }
    }
}
