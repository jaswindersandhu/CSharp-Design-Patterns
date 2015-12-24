using System;
using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class ChicagoStyleCheesePizza : Pizza {
        public ChicagoStyleCheesePizza() {
            _Name = "Chicago Style Deep Dish Cheese Pizza";
            _Dough = "Extra Thick Crust Dough";
            _Sauce = "Plum Tomato Sauce";

            _Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
