using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes {
    class CeilingFan {
        public string Location { get; set; }
        public int Speed { get; set; }
        public const int High = 3;
        public const int Medium = 2;
        public const int Low = 1;
        public const int Off = 0;

        public CeilingFan(string location) {
            Location = location;
            Speed = Off;
        }

        public void SetHigh() {
            Speed = High;
            Console.WriteLine(Location + " ceiling fan is on high");
        }

        public void SetMedium() {
            Speed = Medium;
            Console.WriteLine(Location + " ceiling fan is on medium");
        }

        public void SetLow() {
            Speed = Low;
            Console.WriteLine(Location + " ceiling fan is on low");
        }

        public void SetOff() {
            Speed = Off;
            Console.WriteLine(Location + " ceiling fan is off");
        }
    }
}
