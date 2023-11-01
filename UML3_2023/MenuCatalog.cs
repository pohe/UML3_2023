using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_2023
{
    public class MenuCatalog : IMenuCatalog
    {

        //Definer en collection (List eller Dictionary) til at indeholde IMenuItem

        public MenuCatalog() 
        {
            //Initialiser collection
        }
        public int Count { get; }
        public void Add(IMenuItem aMenuItem)
        { }
        public IMenuItem Search(int number)
        {
            return null;
        }
        public void Delete(int number)
        { }
        public void PrintPizzasMenu()
        { }
        public void PrintBeveragesMenu()
        {

        }
        public void PrintToppingsMenu()
        {
            //Kan evt springes over
        }
        public void Update(int number, IMenuItem theMenuItem)
        {

        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem> ();

            //Gennemløb collection
            //Tag et item ud af gangen
            //Undersøg om det af typen "type" og er vagansk
            //Hvis det er tilfældet så add det til returnList
            return returnList;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            return null;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            return null;
        }

    }
}
