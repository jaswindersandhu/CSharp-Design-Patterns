namespace CommandPattern.RemoteControl.Interfaces {
    interface Command {
        void Execute();
        void Undo();
    }
}
