using FactoryMethod.MyPizzaStore.Abstract_Classes;
using FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.PizzaStore_Extensions {
    class ChicagoPizzaStore : PizzaStore {
        public override Pizza CreatePizza(string type) {
            switch (type) {
                case "cheese": return new ChicagoStyleCheesePizza();
                case "veggie": return new ChicagoStyleVeggiePizza();
                case "clam": return new ChicagoStyleClamPizza();
                case "pepperoni": return new ChicagoStylePepperoniPizza();
                default: return null;
            }
        }
    }
}