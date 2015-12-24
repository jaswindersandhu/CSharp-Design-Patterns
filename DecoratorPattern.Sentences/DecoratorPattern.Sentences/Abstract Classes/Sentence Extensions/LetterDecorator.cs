namespace DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions {
    abstract class LetterDecorator : Sentence {
        public Sentence _Sentence { get; set; }
        public override abstract string _Description { get; }
    }
}
