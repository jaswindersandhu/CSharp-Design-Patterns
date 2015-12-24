using AbstractFactory.MyPizzaStore.Abstract_Classes;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Pizza_Extensions;
using AbstractFactory.MyPizzaStore.Interfaces;
using AbstractFactory.MyPizzaStore.Concrete_Classes.PizzaIngredientFactory_Implementations;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.PizzaStore_Extensions {
    class ChicagoPizzaStore : PizzaStore {
        public override Pizza CreatePizza(string type) {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type) {
                case "cheese": {
                        pizza = new CheesePizza(ingredientFactory);
                        pizza._Name = "Chicago Style Cheese Pizza";
                        break;
                    }
                case "veggie": {
                        pizza = new VeggiePizza(ingredientFactory);
                        pizza._Name = "Chicago Style Veggie Pizza";
                        break;
                    }
                case "clam": {
                        pizza = new ClamPizza(ingredientFactory);
                        pizza._Name = "Chicago Style Clam Pizza";
                        break;
                    }
                case "pepperoni": {
                        pizza = new PepperoniPizza(ingredientFactory);
                        pizza._Name = "Chicago Style Pepperoni Pizza";
                        break;
                    }
                default: return null;
            }

            return pizza;
        }
    }
}
