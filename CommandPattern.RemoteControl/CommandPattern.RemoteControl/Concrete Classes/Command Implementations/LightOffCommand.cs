using System;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class LightOffCommand : Command {
        public Light Light { get; set; }

        public LightOffCommand(Light light) {
            Light = light;
        }

        public void Execute() {
            Light.Off();
        }

        public void Undo() {
            Light.On();
        }
    }
}
