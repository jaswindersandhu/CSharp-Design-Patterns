using FactoryMethod.MyPizzaStore.Abstract_Classes;
using FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.PizzaStore_Extensions {
    class NYPizzaStore : PizzaStore {
        public override Pizza CreatePizza(string type) {
            switch (type) {
                case "cheese": return new NYStyleCheesePizza();
                case "veggie": return new NYStyleVeggiePizza();
                case "clam": return new NYStyleClamPizza();
                case "pepperoni": return new NYStylePepperoniPizza();
                default: return null;
            }
        }
    }
}
