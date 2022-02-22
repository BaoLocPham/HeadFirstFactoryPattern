namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null!;
            if (type.Equals("cheese")){
                pizza = new ChicagoCheesePizza();
            }else if(type.Equals("greek")){
                pizza = new ChicagoGreekPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new ChicagoPepperoniPizza();
            }else if (type.Equals("clam")){
                pizza = new ChicagoClamPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new ChicagoPepperoniPizza();
            }
            return pizza;
        }
    }
}