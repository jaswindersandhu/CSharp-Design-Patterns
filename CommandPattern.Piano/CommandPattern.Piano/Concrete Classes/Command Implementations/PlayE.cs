using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayE : Command {
        public E E { get; set; }

        public PlayE(E e) {
            E = e;
        }

        public void Execute() {
            E.PlayNoteE();
        }

        public void Undo() {
            E.StopPlayingE();
        }
    }
}
