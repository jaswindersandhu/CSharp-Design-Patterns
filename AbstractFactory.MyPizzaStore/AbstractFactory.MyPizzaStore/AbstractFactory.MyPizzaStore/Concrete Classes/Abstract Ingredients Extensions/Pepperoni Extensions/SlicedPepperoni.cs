using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Pepperoni_Extensions {
    class SlicedPepperoni : Pepperoni {
        public override string ToString() {
            return "Sliced Pepperoni";
        }
    }
}
