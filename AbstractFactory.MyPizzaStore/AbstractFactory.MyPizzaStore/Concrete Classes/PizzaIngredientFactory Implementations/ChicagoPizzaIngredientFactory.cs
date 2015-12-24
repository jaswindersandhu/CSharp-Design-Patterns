using AbstractFactory.MyPizzaStore.Interfaces;
using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Cheese_Extensions;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Clams_Extensions;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Dough_Extensions;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Pepperoni_Extensions;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Sauce_Extensions;
using AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Veggies_Extensions;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.PizzaIngredientFactory_Implementations {
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory {
        public Cheese CreateCheese() {
            return new MozzarellaCheese();
        }

        public Clams CreateClams() {
            return new FrozenClams();
        }

        public Dough CreateDough() {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce() {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies() {
            return new Veggies[] { new Spinach(), new Eggplant(), new BlackOlives() };
        }
    }
}
