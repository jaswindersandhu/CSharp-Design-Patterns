using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Clams_Extensions {
    class FrozenClams : Clams {
        public override string ToString() {
            return "Frozen Clams from Chesapeake Bay";
        }
    }
}
