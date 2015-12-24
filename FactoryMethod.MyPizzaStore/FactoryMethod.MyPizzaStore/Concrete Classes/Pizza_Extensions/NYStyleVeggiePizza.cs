using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class NYStyleVeggiePizza : Pizza {
        public NYStyleVeggiePizza() {
            _Name = "NY Style Veggie Pizza";
            _Dough = "Thin Crust Dough";
            _Sauce = "Marinara Sauce";

            _Toppings.Add("Grated Reggiano Cheese");
            _Toppings.Add("Garlic");
            _Toppings.Add("Onion");
            _Toppings.Add("Mushrooms");
            _Toppings.Add("Red Pepper");
        }
    }
}
