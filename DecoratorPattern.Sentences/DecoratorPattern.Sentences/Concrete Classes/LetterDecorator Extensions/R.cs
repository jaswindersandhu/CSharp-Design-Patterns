using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class R : LetterDecorator {
        public override string _Description { get { return "R" + _Sentence._Description; } }

        public R(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
