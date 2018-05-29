using ConsoleApp1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clients
{
    public class RemoteControl
    {
        iCommand[] onCommands;
        iCommand[] offCommands;
        public RemoteControl()
        {
            onCommands = new iCommand[7];
            offCommands = new iCommand[7];

            iCommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, iCommand onCommand, iCommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n=========== Remote Control =============\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append($"\n[Slot {i}] {onCommands[i].GetType().Name} {offCommands[i].GetType().Name}");
            }
            return stringBuilder.ToString(); 
        }

    }
}
