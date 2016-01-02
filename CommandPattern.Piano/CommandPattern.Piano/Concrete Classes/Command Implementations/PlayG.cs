using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayG : Command {
        public G G { get; set; }

        public PlayG(G g) {
            G = g;
        }

        public void Execute() {
            G.PlayNoteG();
        }

        public void Undo() {
            G.StopPlayingG();
        }
    }
}
