using System;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.BeverageSize_Implementations;

namespace DecoratorPattern.StarbuzzCoffee.Driver_Classes {
    class StarbuzzCoffee {
        static void Main(string[] args) {
            Beverage beverage = new Espresso(new TallSize());
            Console.WriteLine(beverage);

            Beverage beverage2 = new DarkRoast(new VentiSize());
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2);

            Beverage beverage3 = new Whip(new Mocha(new Soy(new HouseBlend(new GrandeSize()))));
            Console.WriteLine(beverage3);

            Console.ReadLine();
        }
    }
}
