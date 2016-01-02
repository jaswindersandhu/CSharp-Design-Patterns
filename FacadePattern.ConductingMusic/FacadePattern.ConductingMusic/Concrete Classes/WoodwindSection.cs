using System;

namespace FacadePattern.ConductingMusic.Concrete_Classes {
    class WoodwindSection {
        public void StartPlaying() {
            Console.WriteLine("Woodwinds start piping away");
        }

        public void StopPlaying() {
            Console.WriteLine("Woodwinds stop just before out of breath");
        }
    }
}
