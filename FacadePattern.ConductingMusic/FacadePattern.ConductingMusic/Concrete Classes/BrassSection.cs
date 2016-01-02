using System;

namespace FacadePattern.ConductingMusic.Concrete_Classes {
    class BrassSection {
        public void StartPlaying() {
            Console.WriteLine("Brass is blowing hard");
        }

        public void StopPlaying() {
            Console.WriteLine("Brass stopped playing");
        }
    }
}
