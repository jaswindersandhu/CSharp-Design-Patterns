using CommandPattern.RemoteControl.Interfaces;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class StereoOnWithCdCommand : Command {
        public Stereo Stereo { get; set; }

        public StereoOnWithCdCommand(Stereo stereo) {
            Stereo = stereo;
        }

        public void Execute() {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }

        public void Undo() {
            Stereo.Off();
        }
    }
}
