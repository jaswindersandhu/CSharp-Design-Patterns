using System;

namespace FacadePattern.ConductingMusic.Concrete_Classes {
    class PercussionSection {
        public void StartPlaying() {
            Console.WriteLine("Percussion is banging away");
        }

        public void StopPlaying() {
            Console.WriteLine("Percussion stopped playing (surprisingly)");
        }
    }
}
