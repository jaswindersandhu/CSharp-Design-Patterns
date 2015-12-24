using System;
using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class ChicagoStyleClamPizza : Pizza {
        public ChicagoStyleClamPizza() {
            _Name = "Chicago Style Clam Pizza";
            _Dough = "Extra Thick Crust Dough";
            _Sauce = "Plum Tomato Sauce";

            _Toppings.Add("Shredded Mozzarella Cheese");
            _Toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
