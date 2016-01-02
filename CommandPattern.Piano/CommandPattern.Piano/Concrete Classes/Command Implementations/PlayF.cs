using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayF : Command {
        public F F { get; set; }

        public PlayF(F f) {
            F = f;
        }

        public void Execute() {
            F.PlayNoteF();
        }

        public void Undo() {
            F.StopPlayingF();
        }
    }
}
