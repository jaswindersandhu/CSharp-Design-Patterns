using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class CeilingFanLowCommand : Command {
        public CeilingFan CeilingFan { get; set; }
        public int PrevSpeed { get; set; }

        public CeilingFanLowCommand(CeilingFan ceilingFan) {
            CeilingFan = ceilingFan;
        }
        public void Execute() {
            PrevSpeed = CeilingFan.Speed;
            CeilingFan.SetLow();
        }

        public void Undo() {
            switch (PrevSpeed) {
                case CeilingFan.High: CeilingFan.SetHigh(); break;
                case CeilingFan.Medium: CeilingFan.SetMedium(); break;
                case CeilingFan.Low: CeilingFan.SetLow(); break;
                case CeilingFan.Off: CeilingFan.SetOff(); break;
            }
        }
    }
}
