namespace FactoryPattern
{
    public class ChicagoCheesePizza : Pizza{
        public ChicagoCheesePizza(){
            name = "Chicago style Deep Dish Cheese pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut(){
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
    }

    public class ChicagoGreekPizza : Pizza{

    }

    public class ChicagoPepperoniPizza: Pizza{

    }

    public class ChicagoClamPizza : Pizza{

    }

    public class ChicagoVeggie : Pizza{
        
    }
}