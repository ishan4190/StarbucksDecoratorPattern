using BusinessLayer.Classes;

public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Startbucks");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        Console.WriteLine("Menu");
        Console.WriteLine("Would you like a hot coffee or ColdCoffee? \n 0. Hot Coffee \n 1. Cold Coffee \n\n Enter your choice : ");
        bool hotOrCold = Convert.ToBoolean( Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("\n \n Please pick the type of coffee you want from the selection: \n 1. Latte \n 2. Macchiato \n ");
        int coffeeType = Convert.ToInt32(Console.ReadLine());

        if(coffeeType == 1)
        {
            var decoratedCoffe = new LatteCoffee(hotOrCold ? new ColdCoffee() : new HotCoffee());
            Console.WriteLine($"Use this recipe for {nameof(decoratedCoffe)} \n");
            Console.WriteLine(decoratedCoffe.CreateCoffeeRecipe());
        }
        else
        {
            var decoratedCoffeMachiato = new MachiatoCoffee(hotOrCold ? new ColdCoffee() : new HotCoffee());
            Console.WriteLine($"Use this recipe for {nameof(decoratedCoffeMachiato)} \n");
            Console.WriteLine(decoratedCoffeMachiato.CreateCoffeeRecipe());
        }

    }
}