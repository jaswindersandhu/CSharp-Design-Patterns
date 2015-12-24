using AbstractFactory.MyPizzaStore.Abstract_Classes.Abstract_Ingredients;

namespace AbstractFactory.MyPizzaStore.Interfaces {
    interface PizzaIngredientFactory {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams(); 
    }
}
