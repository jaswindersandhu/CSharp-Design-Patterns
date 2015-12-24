using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class NYStyleCheesePizza : Pizza {
        public NYStyleCheesePizza() {
            _Name = "NY Style Sauce and Cheese Pizza";
            _Dough = "Thin Crust Dough";
            _Sauce = "Marinara Sauce";

            _Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
