using CommandPattern.RemoteControl.Interfaces;

namespace CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations {
    class MacroCommand : Command {
        public Command[] Commands { get; set; }

        public MacroCommand(Command[] commands) {
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
