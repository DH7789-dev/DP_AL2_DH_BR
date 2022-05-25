namespace ClassLibrary1;public class AskUser{    private List<Sandwich> _sandwichMenu;    private Order _order;    public AskUser(List<Sandwich> sandwichMenu)    {        _sandwichMenu = sandwichMenu;        _order = new Order(new List<Sandwich>());    }    public Order Order    {        get => _order;        set => _order = value ?? throw new ArgumentNullException(nameof(value));    }    public List<Sandwich> SandwichMenu    {        get => _sandwichMenu;        set => _sandwichMenu = value ?? throw new ArgumentNullException(nameof(value));    }    public void ShowMenu()    {        Console.WriteLine("List of sandwich available:");        _sandwichMenu.ForEach(sandwich =>        {            Console.WriteLine(" - " + sandwich.Name + " : " + sandwich.IngredientsToString());        });    }    public void AskSandwichUser()    {        Boolean validate = false;        while (validate)        {            Console.WriteLine("Write down the sandwich name you want to add to your order (name of sandwich with ',')");            Console.WriteLine("Exemple : jambon beurre, jambon beurre, Diepois");                        string? order = Console.ReadLine();            validate = ValidateOrder(order);        }    }    private bool ValidateOrder(string? order)    {        String[] sandwichs = order.Split(',');        foreach (String orderedSandwich in sandwichs)        {            foreach (Sandwich sandwich in _sandwichMenu)            {                if (orderedSandwich.Equals(sandwich.Name))                {                    _order.addSandwich(sandwich);                }            }        }        if (_order.Sandwiches.Count != sandwichs.Length)        {            Console.WriteLine("Your order is wrong !");            return false;        }                return true;    }    public void ShowOrder()    {        Console.WriteLine("Your order is :");        Console.WriteLine(_order.ToString());    }}