using FactoryMethod.MyPizzaStore.Abstract_Classes;
using FactoryMethod.MyPizzaStore.Concrete_Classes.Pizza_Extensions;

namespace FactoryMethod.MyPizzaStore.Concrete_Classes.PizzaStore_Extensions {
    class CaliforniaPizzaStore : PizzaStore {
        public override Pizza CreatePizza(string type) {
            switch (type) {
                //case "cheese": return new CaliforniaStyleCheesePizza();
                //case "veggie": return new CaliforniaStyleVeggiePizza();
                //case "clam": return new CaliforniaStyleClamPizza();
                //case "pepperoni": return new CaliforniaStylePepperoniPizza();
                default: return null;
            }
        }
    }
}
