using System;
namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class G {
        public void PlayNoteG() {
            Console.WriteLine("G~~~");
        }

        public void StopPlayingG() {
            Console.WriteLine("G rested");
        }
    }
}
