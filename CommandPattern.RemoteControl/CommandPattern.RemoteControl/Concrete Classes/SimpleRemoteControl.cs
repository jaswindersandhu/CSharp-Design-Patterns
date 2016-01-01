using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes {
    class SimpleRemoteControl {
        public Command Slot { get; set; }

        public SimpleRemoteControl() { }

        public void ButtonWasPressed() {
            Slot.Execute();
        }
    }
}
