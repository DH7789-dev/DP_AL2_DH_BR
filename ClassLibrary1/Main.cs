namespace ClassLibrary1;

public class Main
{
    
    public static void main()
    {
        MenuSandwich menuSandwich = new MenuSandwich();
        menuSandwich.InitialiseData();

        AskUser askUser = new AskUser(menuSandwich.Sandwiches);
        askUser.ShowMenu();
        askUser.AskSandwichUser();
        askUser.ShowOrder();

    }
}