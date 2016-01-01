using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes {
    class Stereo {
        public string Location { get; set; }

        public Stereo(string location) {
            Location = location;
        }

        public void On() {
            Console.WriteLine("Stereo is on");
        }

        public void Off() {
            Console.WriteLine("Stereo is off");
        }

        public void SetCd() {
            Console.WriteLine("Stereo CD is set");
        }

        public void SetDvd() {
            Console.WriteLine("Stereo DVD is set");
        }

        public void SetRadio() {
            Console.WriteLine("Stereo radio is set");
        }

        public void SetVolume(int volume) {
            Console.WriteLine("Stereo volume is set to " + volume);
        }
    }
}
