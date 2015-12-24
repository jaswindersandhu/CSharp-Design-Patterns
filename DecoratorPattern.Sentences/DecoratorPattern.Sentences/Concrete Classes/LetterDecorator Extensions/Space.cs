using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Abstract_Classes.Sentence_Extensions;

namespace DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions {
    class Space : LetterDecorator {
        public override string _Description { get { return " " + _Sentence._Description; } }

        public Space(Sentence sentence) {
            _Sentence = sentence;
        }
    }
}
