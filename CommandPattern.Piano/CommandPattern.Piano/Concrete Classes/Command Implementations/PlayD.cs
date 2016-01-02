using CommandPattern.Piano.Concrete_Classes.Pitch_Classes;
using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class PlayD : Command {
        public D D { get; set; }

        public PlayD(D d) {
            D = d;
        }

        public void Execute() {
            D.PlayNoteD();
        }

        public void Undo() {
            D.StopPlayingD();
        }
    }
}
