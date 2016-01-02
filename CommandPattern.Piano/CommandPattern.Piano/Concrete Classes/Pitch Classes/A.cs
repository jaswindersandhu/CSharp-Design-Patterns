using System;

namespace CommandPattern.Piano.Concrete_Classes.Pitch_Classes {
    class A {
        public void PlayNoteA() {
            Console.WriteLine("A~~~");
        }

        public void StopPlayingA() {
            Console.WriteLine("A rested");
        }
    }
}
