using CommandPattern.RemoteControl.Concrete_Classes.Command_Implementations;
using CommandPattern.RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.RemoteControl.Concrete_Classes {
    class BetterRemoteControl {
        public Command[] OnCommands { get; set; }
        public Command[] OffCommands { get; set; }
        public Stack<Command> UndoCommands { get; set; } = new Stack<Command>();

        public BetterRemoteControl() : this(7) { }

        public BetterRemoteControl(int numSlots) {
            OnCommands = new Command[numSlots];
            OffCommands = new Command[numSlots];

            Command noCommand = new NoCommand();
            UndoCommands.Push(noCommand);

            for (int i = 0; i < numSlots; i++) {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand) {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot) {
            OnCommands[slot].Execute();
            UndoCommands.Push(OnCommands[slot]);
        }

        public void OffButtonWasPushed(int slot) {
            OffCommands[slot].Execute();
            UndoCommands.Push(OffCommands[slot]);
        }

        public void UndoButtonWasPushed() {
            if (UndoCommands.Count > 0) {
                UndoCommands.Pop().Undo();
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < OnCommands.Length; i++) {
                sb.Append("[slot " + i + "] " + OnCommands[i].GetType().Name + "    " + OffCommands[i].GetType().Name + "\n");
            }

            return sb.ToString();
        }
    }
}
