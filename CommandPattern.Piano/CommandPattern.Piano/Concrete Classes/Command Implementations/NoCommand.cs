using CommandPattern.Piano.Interfaces;

namespace CommandPattern.Piano.Concrete_Classes.Command_Implementations {
    class NoCommand : Command {
        public void Execute() { }

        public void Undo() { }
    }
}
