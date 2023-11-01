// See https://aka.ms/new-console-template for more information
using UML3_2023;

Console.WriteLine("Hello, World!");



IMenuCatalog catalog = new MenuCatalog();

//Test af search
IMenuItem foundItem = catalog.Search(12);
if (foundItem != null)
{
    Console.WriteLine($"Fandt {foundItem}");
}

//Test af FIndAllVegan

Console.WriteLine("Alle vegan items af typen pizza");
List<IMenuItem> veganItems = catalog.FindAllVegan(MenuType.Pizza);
foreach(IMenuItem item in veganItems)
{ Console.WriteLine(item.Name ); }