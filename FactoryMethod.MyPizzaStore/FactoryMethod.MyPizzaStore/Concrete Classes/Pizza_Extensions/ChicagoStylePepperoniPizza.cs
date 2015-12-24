using System;
using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class ChicagoStylePepperoniPizza : Pizza {
        public ChicagoStylePepperoniPizza() {
            _Name = "Chicago Style Pepperoni Pizza";
            _Dough = "Extra Thick Crust Dough";
            _Sauce = "Plum Tomato Sauce";

            _Toppings.Add("Shredded Mozzarella Cheese");
            _Toppings.Add("Black Olives");
            _Toppings.Add("Spinach");
            _Toppings.Add("Eggplant");
            _Toppings.Add("Sliced Pepperoni");
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
