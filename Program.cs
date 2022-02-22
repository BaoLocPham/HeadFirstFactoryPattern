// See https://aka.ms/new-console-template for more information
using FactoryPattern;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.orderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza.getName());

pizza = chicagoStore.orderPizza("cheese");
Console.WriteLine("Joel ordered a " + pizza.getName());
