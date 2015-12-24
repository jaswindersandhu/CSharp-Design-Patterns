using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class D : LetterDecorator {
        public override string _Description { get { return "D" + _Sentence._Description; } }

        public D(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
