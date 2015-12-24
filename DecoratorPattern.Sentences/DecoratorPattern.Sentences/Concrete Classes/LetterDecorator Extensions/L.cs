using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class L : LetterDecorator {
        public override string _Description { get { return "L" + _Sentence._Description; } }

        public L(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
