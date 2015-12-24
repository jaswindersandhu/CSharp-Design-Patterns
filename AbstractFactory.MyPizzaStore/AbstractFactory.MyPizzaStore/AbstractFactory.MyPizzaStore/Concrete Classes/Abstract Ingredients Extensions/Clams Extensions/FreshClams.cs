using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Clams_Extensions {
    class FreshClams : Clams {
        public override string ToString() {
            return "Fresh Clams from Long Island Sound";
        }
    }
}
