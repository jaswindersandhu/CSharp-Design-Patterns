using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class NYStyleClamPizza : Pizza {
        public NYStyleClamPizza() {
            _Name = "NY Style Clam Pizza";
            _Dough = "Thin Crust Dough";
            _Sauce = "Marinara Sauce";

            _Toppings.Add("Grated Reggiano Cheese");
            _Toppings.Add("Fresh Clams from Long Island Sound");
        }
    }
}
