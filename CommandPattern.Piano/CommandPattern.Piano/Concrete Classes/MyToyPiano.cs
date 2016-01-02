using CommandPattern.Piano.Concrete_Classes.Command_Implementations;
using CommandPattern.Piano.Interfaces;
using System.Collections.Generic;

namespace CommandPattern.Piano.Concrete_Classes {
    class MyToyPiano {
        public Command[] PlayCommands { get; set; }
        public Stack<Command> UndoCommands { get; set; } = new Stack<Command>();

        public MyToyPiano() : this(7) { }

        public MyToyPiano(int numKeys) {
            PlayCommands = new Command[numKeys];
            Command noCommand = new NoCommand();
            UndoCommands.Push(noCommand);

            for (int i = 0; i < numKeys; i++) {
                PlayCommands[i] = noCommand;
            }
        }

        public void SetCommand(int key, Command playCommand) {
            if (key < PlayCommands.Length && key >= 0) {
                PlayCommands[key] = playCommand;
            }
        }

        public void PressKey(int key) {
            PlayCommands[key].Execute();
            UndoCommands.Push(PlayCommands[key]);
        }

        public void UndoLastCommand() {
            if (UndoCommands.Count > 0) {
                UndoCommands.Pop().Undo();
            }
        }
    }
}
