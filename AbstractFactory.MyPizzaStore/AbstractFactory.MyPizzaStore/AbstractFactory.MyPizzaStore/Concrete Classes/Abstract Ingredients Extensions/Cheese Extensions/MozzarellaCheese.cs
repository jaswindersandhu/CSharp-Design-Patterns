using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Cheese_Extensions {
    class MozzarellaCheese  : Cheese {
        public override string ToString() {
            return "Shredded Mozzarella";
        }
    }
}
