using CommandPattern.RemoteControl.Interfaces;
using CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes;
using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class StereoOffCommand : Command {
        public Stereo Stereo { get; set; }

        public StereoOffCommand(Stereo stereo) {
            Stereo = stereo;
        }

        public void Execute() {
            Stereo.Off();
        }

        public void Undo() {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }
    }
}
