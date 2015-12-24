using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Concrete_Classes.Abstract_Ingredients_Extensions.Dough_Extensions {
    class ThickCrustDough : Dough {
        public override string ToString() {
            return "Extra Thick Crust Dough";
        }
    }
}
