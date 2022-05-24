namespace ClassLibrary1;

public class Ingredient
{
    private string name;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Ingredient(string name)
    {
        this.name = name;
    }
}