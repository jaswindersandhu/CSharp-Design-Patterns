using DecoratorPattern.Sentences.Abstract_Classes;
using DecoratorPattern.Sentences.Concrete_Classes.Sentence_Extensions;
using DecoratorPattern.Sentences.Concrete_Classes.LetterDecorator_Extensions;
using System;

namespace DecoratorPattern.Sentences.Driver_Classes {
    class SentenceDriver {
        static void Main(string[] args) {
            Sentence sentence = new H(new E(new L(new L(new O(new Space(new W(new O(new R(new L(new D(new ExclamationMark())))))))))));
            Console.WriteLine(sentence);

            Console.ReadLine();
        }
    }
}
