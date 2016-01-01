using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class LightOnCommand : Command {
        public Light Light { get; set; }

        public LightOnCommand(Light light) {
            Light = light;
        }

        public void Execute() {
            Light.On();
        }

        public void Undo() {
            Light.Off();
        }
    }
}
