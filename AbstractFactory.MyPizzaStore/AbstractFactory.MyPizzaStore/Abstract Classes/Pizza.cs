using System;
using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;
using System.Text;

namespace AbstractFactory.MyPizzaStore.Abstract_Classes {
    abstract class Pizza {
        public string _Name { get; set; }
        public Dough _Dough { get; set; }
        public Sauce _Sauce { get; set; }
        public Veggies[] _Veggies { get; set; }
        public Cheese _Cheese { get; set; }
        public Pepperoni _Pepperoni { get; set; }
        public Clams _Clams { get; set; }

        public abstract void Prepare();

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
            StringBuilder result = new StringBuilder();
            result.Append("---- " + _Name + " ----\n");
            if (_Dough != null) {
                result.Append(_Dough);
                result.Append("\n");
            }
            if (_Sauce != null) {
                result.Append(_Sauce);
                result.Append("\n");
            }
            if (_Cheese != null) {
                result.Append(_Cheese);
                result.Append("\n");
            }
            if (_Veggies != null) {
                for (int i = 0; i < _Veggies.Length; i++) {
                    result.Append(_Veggies[i]);
                    if (i < _Veggies.Length - 1) {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (_Clams != null) {
                result.Append(_Clams);
                result.Append("\n");
            }
            if (_Pepperoni != null) {
                result.Append(_Pepperoni);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
