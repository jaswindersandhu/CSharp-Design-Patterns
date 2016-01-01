using CommandPattern.RemoteControl.Interfaces;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class GarageDoorOpenCommand : Command {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorOpenCommand(GarageDoor garageDoor) {
            GarageDoor = garageDoor;
        }

        public void Execute() {
            GarageDoor.Up();
        }

        public void Undo() {
            GarageDoor.Down();
        }
    }
}
