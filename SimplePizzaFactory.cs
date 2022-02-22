namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type){
            Pizza pizza = null!;

            if (type.Equals("cheese")){
                pizza = new CheesePizza();
            }else if(type.Equals("greek")){
                pizza = new GreekPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new PepperoniPizza();
            }else if (type.Equals("clam")){
                pizza = new ClamPizza();
            }else if (type.Equals("pepperoni")){
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}