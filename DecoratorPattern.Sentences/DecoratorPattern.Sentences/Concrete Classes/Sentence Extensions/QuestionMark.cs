using DecoratorPattern.Sentences.Abstract_Classes;

namespace DecoratorPattern.Sentences.Concrete_Classes.Sentence_Extensions {
    class QuestionMark : Sentence {
        public QuestionMark() {
            _Description = "?";
        }
    }
}
