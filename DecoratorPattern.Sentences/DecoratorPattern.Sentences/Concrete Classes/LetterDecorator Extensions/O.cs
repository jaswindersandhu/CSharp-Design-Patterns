using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class O : LetterDecorator {
        public override string _Description { get { return "O" + _Sentence._Description; } }

        public O(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
