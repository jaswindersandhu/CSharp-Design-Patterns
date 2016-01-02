using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayC : Command {
        public C C { get; set; }

        public PlayC(C c) {
            C = c;
        }

        public void Execute() {
            C.PlayNoteC();
        }

        public void Undo() {
            C.StopPlayingC();
        }
    }
}
