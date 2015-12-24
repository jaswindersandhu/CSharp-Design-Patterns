namespace DecoratorPattern.Sentences.Abstract_Classes {
    abstract class Sentence {
        public virtual string _Description { get; set; }

        public override string ToString() {
            return _Description;
        }
    }
}
