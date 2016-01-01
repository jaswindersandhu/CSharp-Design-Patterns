using System;

namespace CommandPattern.RemoteControl.Concrete_Classes.Vendor_Classes {
    class GarageDoor {
        public string Location { get; set; }

        public GarageDoor(string location) {
            Location = location;
        }

        public void Up() {
            Console.WriteLine(Location + " garage door is up");
        }

        public void Down() {
            Console.WriteLine(Location + " garage door is down");
        }

        public void Stop() {
            Console.WriteLine(Location + " garage door is stopped");
        }

        public void LightOn() {
            Console.WriteLine(Location + " garage light is on");
        }

        public void LightOff() {
            Console.WriteLine(Location + " garage light is off");
        }
    }
}
