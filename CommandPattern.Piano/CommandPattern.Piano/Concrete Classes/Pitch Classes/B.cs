using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class B {
        public void PlayNoteB() {
            Console.WriteLine("B~~~");
        }

        public void StopPlayingB() {
            Console.WriteLine("B rested");
        }
    }
}
