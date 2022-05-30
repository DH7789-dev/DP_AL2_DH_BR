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

    // TODO: Créer une classe apart pour InitializeData
    public void InitialiseData()
    {
        List<Ingredient> _ingredients = new List<Ingredient>();
        _ingredients.Add(new Ingredient("1 pain"));
        _ingredients.Add(new Ingredient("1 tranche de jambon"));
        _ingredients.Add(new Ingredient("10g de beurre"));
        
        _sandwiches.Add(new Sandwich("Jambon beurre", _ingredients, 3.5));
        
        List<Ingredient> _ingredients2 = new List<Ingredient>();
        _ingredients2.Add(new Ingredient("1 pain"));
        _ingredients2.Add(new Ingredient("1 oeuf"));
        _ingredients2.Add(new Ingredient("0.5 tomate"));
        _ingredients2.Add(new Ingredient("1 tranche de poulet"));
        _ingredients2.Add(new Ingredient("10g de mayonnaise"));
        _ingredients2.Add(new Ingredient("10g de salade"));
        
        _sandwiches.Add(new Sandwich("Poulet Crudités", _ingredients2, 5));
        
        List<Ingredient> _ingredients3 = new List<Ingredient>();
        _ingredients3.Add(new Ingredient("1 pain"));
        _ingredients3.Add(new Ingredient("50g de thon"));
        _ingredients2.Add(new Ingredient("0.5 tomate"));
        _ingredients2.Add(new Ingredient("10g de mayonnaise"));
        _ingredients2.Add(new Ingredient("10g de salade"));
        
        _sandwiches.Add(new Sandwich("Diepois", _ingredients3, 4.5));
    }
}