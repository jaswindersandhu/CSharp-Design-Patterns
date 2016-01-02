namespace CommandPattern.Piano.Interfaces {
    interface Command {
        void Execute();
        void Undo();
    }
}
