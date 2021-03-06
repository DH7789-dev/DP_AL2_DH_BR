using System.Text;
using ClassLibrary1;

namespace FP_AL2_FH_BR;

public class Order
{
    private List<Sandwich> _sandwiches;
    IDictionary<string, string> recipe = new Dictionary<string, string>();

    public List<Sandwich> Sandwiches
    {
        get => _sandwiches;
        set => _sandwiches = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Order(List<Sandwich> sandwiches)
    {
        _sandwiches = sandwiches;
    }

    public void addSandwich(Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }

    public double getPriceOrder()
    {
        double priceOrder = 0;
        foreach (Sandwich sandwich in _sandwiches)
        {
            priceOrder += sandwich.Price;
        }

        return priceOrder;
    }
    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        if (_sandwiches.Count == 0)
        {
            return "No sandwich";
        }

        for (int i = 0; i < _sandwiches.Count; i++)
        {
            result.Append(sandwichToString(result, _sandwiches[i], i.ToString()));
        }

        result.Append("price : " + getPriceOrder());
        return result.ToString();
    }

    private StringBuilder sandwichToString(StringBuilder stringBuilder,Sandwich sandwich,string numberOrder)
    {
        stringBuilder.Append(numberOrder + ":" + sandwich.Name + "\n");
        sandwich.Ingredients.ForEach(ingredient =>
        {
            stringBuilder.Append("         " + ingredient.Name + "\n");
        });

        return stringBuilder;
    }
}