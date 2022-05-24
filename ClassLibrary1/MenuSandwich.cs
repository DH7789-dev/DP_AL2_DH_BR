namespace ClassLibrary1;

public class MenuSandwich
{
    private List<Sandwich> _sandwiches;

    public List<Sandwich> Sandwiches
    {
        get => _sandwiches;
        set => _sandwiches = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void add(Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }
    
    public MenuSandwich()
    {
        _sandwiches = new List<Sandwich>();
    }
}