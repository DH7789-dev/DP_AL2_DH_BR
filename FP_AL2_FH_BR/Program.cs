// See https://aka.ms/new-console-template for more information

using ClassLibrary1;

MenuSandwich menuSandwich = new MenuSandwich();
menuSandwich.InitialiseData();

AskUser askUser = new AskUser(menuSandwich.Sandwiches);
askUser.ShowMenu();
askUser.AskSandwichUser();
askUser.ShowOrder();