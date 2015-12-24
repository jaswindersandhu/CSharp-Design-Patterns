using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class H : LetterDecorator {
        public override string _Description { get { return "H" + _Sentence._Description; } }

        public H(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
