using System;
using System.Collections.Generic;

namespace FactoryMethod.MyPizzaStore.Abstract_Classes {
    abstract class Pizza {
        public string _Name { get; set; }
        public string _Dough { get; set; }
        public string _Sauce { get; set; }
        public IList<string> _Toppings { get; set; } = new List<string>();

        public virtual void Prepare() {
            Console.WriteLine("Preparing " + _Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            foreach (string t in _Toppings) {
                Console.WriteLine(t);
            }
        }

        public virtual void Bake() {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box() {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
