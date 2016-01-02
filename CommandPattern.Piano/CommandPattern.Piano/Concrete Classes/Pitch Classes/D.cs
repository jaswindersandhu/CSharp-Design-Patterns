using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class D {
        public void PlayNoteD() {
            Console.WriteLine("D~~~");
        }

        public void StopPlayingD() {
            Console.WriteLine("D rested");
        }
    }
}
