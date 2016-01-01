using System;
using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class NoCommand : Command {
        public void Execute() { }

        public void Undo() { }
    }
}
