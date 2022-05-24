namespace ClassLibrary1;

public class Main
{
    
    public static void main()
    {
        MenuSandwich menuSandwich = new MenuSandwich();
        Ingredient ingredientSandwich1 = new Ingredient("tomate");
        //Sandwich sandwich1 = new Sandwich("sandwich",);
        
        Console.Write("Hello ");
        Console.WriteLine("World!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Good day, ");
        Console.Write(name);
        Console.WriteLine("!");

    }
}