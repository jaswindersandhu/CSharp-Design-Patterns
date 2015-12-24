using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Sauce_Extensions {
    class PlumTomatoSauce : Sauce {
        public override string ToString() {
            return "Tomato sauce with plum tomatoes";
        }
    }
}
