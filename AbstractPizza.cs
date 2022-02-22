using System.Collections;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string name=null!;
        public string dough=null!;
        public string sauce=null!;
        public ArrayList toppings = new ArrayList();

        public virtual void prepare(){
            Console.WriteLine("Preparing "+ name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" "+toppings[i]);
            }
        }

        public virtual void bake(){
            Console.WriteLine("Bake for 20minutes at 350c");
        }

        public virtual void cut(){
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void box(){
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string getName(){
            return name;
        }
    }
    public class CheesePizza : Pizza{

    }

    public class GreekPizza : Pizza{

    }

    public class PepperoniPizza: Pizza{

    }

    public class ClamPizza : Pizza{

    }

    public class Veggie : Pizza{

    }
}