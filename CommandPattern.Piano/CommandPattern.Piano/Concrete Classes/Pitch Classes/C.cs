using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class C {
        public void PlayNoteC() {
            Console.WriteLine("C~~~");
        }

        public void StopPlayingC() {
            Console.WriteLine("C rested");
        }
    }
}
