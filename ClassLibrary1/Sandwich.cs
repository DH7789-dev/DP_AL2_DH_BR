using System.Collections;
using System.Text;

namespace ClassLibrary1;

public class Sandwich
{
    private string _name;
    private List<Ingredient> _ingredients;
    private double _price;
    
    public string Name    // the Name property
    {
        get => _name;
        set => _name = value;
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }

    public List<Ingredient> Ingredients   // the Name property
    {
        get => _ingredients;
        set => _ingredients = value;
    }

    public Sandwich(string name, List<Ingredient> ingredients, double price)
    {
        _name = name;
        _ingredients = ingredients;
        _price = price;
    }


    public String IngredientsToString()
    {
        StringBuilder result = new StringBuilder();
        _ingredients.ForEach(ingredient =>
        {
            result.Append(ingredient.Name);
        } );

        return result.ToString();
    }
}