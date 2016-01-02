using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class E {
        public void PlayNoteE() {
            Console.WriteLine("E~~~");
        }

        public void StopPlayingE() {
            Console.WriteLine("E rested");
        }
    }
}
