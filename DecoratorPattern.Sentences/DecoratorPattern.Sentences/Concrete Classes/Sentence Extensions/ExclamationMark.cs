using DecoratorPattern.Sentences.Abstract_Classes;

namespace DecoratorPattern.Sentences.Concrete_Classes.Sentence_Extensions {
    class ExclamationMark : Sentence {
        public ExclamationMark() {
            _Description = "!";
        }
    }
}
