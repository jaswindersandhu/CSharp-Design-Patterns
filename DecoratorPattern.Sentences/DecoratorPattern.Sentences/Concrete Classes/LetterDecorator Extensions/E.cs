using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class E : LetterDecorator {
        public override string _Description { get { return "E" + _Sentence._Description; } }

        public E(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
