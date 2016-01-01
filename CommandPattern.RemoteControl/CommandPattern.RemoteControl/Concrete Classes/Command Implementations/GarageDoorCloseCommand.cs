using CommandPattern.RemoteControl.Interfaces;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class GarageDoorCloseCommand : Command {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorCloseCommand(GarageDoor garageDoor) {
            GarageDoor = garageDoor;
        }

        public void Execute() {
            GarageDoor.Down();
        }

        public void Undo() {
            GarageDoor.Up();
        }
    }
}
