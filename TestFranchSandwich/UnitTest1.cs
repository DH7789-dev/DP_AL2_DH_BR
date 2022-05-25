using ClassLibrary1;

namespace TestFranchSandwich;

public class Tests
{
    [Test]
    public void Test_should_set_order()
    {
        MenuSandwich menuSandwich = new MenuSandwich();
        menuSandwich.InitialiseData();

        AskUser askUser = new AskUser(menuSandwich.Sandwiches);
        askUser.ValidateOrder("Jambon beurre,Jambon beurre,Diepois");
        Console.WriteLine(askUser.Order.Sandwiches.Count);
        Assert.IsTrue(askUser.Order.Sandwiches.Count.Equals(3));
    }
    
    [Test]
    public void Test_should_not_set_order()
    {
        MenuSandwich menuSandwich = new MenuSandwich();
        menuSandwich.InitialiseData();

        AskUser askUser = new AskUser(menuSandwich.Sandwiches);
        askUser.ValidateOrder("jambonbeurre, jambon beurre, Diepois");
        Assert.IsTrue(askUser.Order.Sandwiches.Count.Equals(0));
    }
}