using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayB : Command {
        public B B { get; set; }

        public PlayB(B b) {
            B = b;
        }

        public void Execute() {
            B.PlayNoteB(); 
        }

        public void Undo() {
            B.StopPlayingB();
        }
    }
}
