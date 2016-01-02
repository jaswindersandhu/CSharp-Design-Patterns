using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class Chord : Command {
        public Command[] Commands { get; set; }

        public Chord(Command[] commands) {
            Commands = commands;
        }

        public void Execute() {
            foreach (Command c in Commands) {
                c.Execute();
            }
        }

        public void Undo() {
            foreach (Command c in Commands) {
                c.Undo();
            }
        }
    }
}
