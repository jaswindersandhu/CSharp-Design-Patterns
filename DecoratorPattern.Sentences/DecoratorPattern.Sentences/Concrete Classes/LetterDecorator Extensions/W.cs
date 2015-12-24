using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class W : LetterDecorator {
        public override string _Description { get { return "W" + _Sentence._Description; } }

        public W(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
