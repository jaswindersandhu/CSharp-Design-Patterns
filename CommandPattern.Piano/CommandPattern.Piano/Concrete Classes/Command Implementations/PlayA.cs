using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayA : Command {
        public A A { get; set; }

        public PlayA(A a) {
            A = a;
        }

        public void Execute() {
            A.PlayNoteA();
        }

        public void Undo() {
            A.StopPlayingA();
        }
    }
}
