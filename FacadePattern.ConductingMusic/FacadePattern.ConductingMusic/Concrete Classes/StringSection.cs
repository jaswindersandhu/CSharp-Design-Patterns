using System;

namespace FacadePattern.ConductingMusic.Concrete_Classes {
    class StringSection {
        public void StartPlaying() {
            Console.WriteLine("Strings start playing elegantly");
        }

        public void StopPlaying() {
            Console.WriteLine("Strings fizzle out");
        }
    }
}
