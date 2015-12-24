using DecoratorPattern.Sentences.Abstract_Classes;

namespace DecoratorPattern.Sentences.Concrete_Classes.Sentence_Extensions {
    class Period : Sentence {
        public Period() {
            _Description = ".";
        }
    }
}
