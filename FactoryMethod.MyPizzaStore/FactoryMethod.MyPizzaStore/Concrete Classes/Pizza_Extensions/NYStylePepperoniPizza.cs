using FactoryMethod.MyPizzaStore.Abstract_Classes;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions {
    class NYStylePepperoniPizza : Pizza {
        public NYStylePepperoniPizza() {
            _Name = "NY Style Pepperoni Pizza";
            _Dough = "Thin Crust Dough";
            _Sauce = "Marinara Sauce";

            _Toppings.Add("Grated Reggiano Cheese");
            _Toppings.Add("Sliced Pepperoni");
            _Toppings.Add("Garlic");
            _Toppings.Add("Onion");
            _Toppings.Add("Mushrooms");
            _Toppings.Add("Red Pepper");
        }
    }
}
