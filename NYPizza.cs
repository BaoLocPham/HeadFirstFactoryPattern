namespace FactoryPattern
{
    public class NYCheesePizza : Pizza{
        public NYCheesePizza(){
            name = "NY style Sauce and Cheese pizza";
            dough = "Thin Crust Dough";
            sauce = "Mariana Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }

    public class NYGreekPizza : Pizza{

    }

    public class NYPepperoniPizza: Pizza{

    }

    public class NYClamPizza : Pizza{

    }

    public class NYVeggie : Pizza{
        
    }
}