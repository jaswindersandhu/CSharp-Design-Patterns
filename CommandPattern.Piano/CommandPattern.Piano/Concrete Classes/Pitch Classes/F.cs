using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class F {
        public void PlayNoteF() {
            Console.WriteLine("F~~~");
        }

        public void StopPlayingF() {
            Console.WriteLine("F rested");
        }
    }
}
