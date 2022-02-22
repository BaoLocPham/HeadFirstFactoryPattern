namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null!;
            if (type.Equals("cheese")){
                pizza = new NYCheesePizza();
            }else if(type.Equals("greek")){
                pizza = new NYGreekPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new NYPepperoniPizza();
            }else if (type.Equals("clam")){
                pizza = new NYClamPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new NYPepperoniPizza();
            }
            return pizza;
        }
    }
}