using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_2023
{
    public class MenuItem:IMenuItem
    {
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, 
            string name, 
            string description, 
            double price, 
            MenuType menutype, 
            bool isVegan, 
            bool isOrganic) 
        {
            //Implementer
        }

        public virtual string PrintInfo()
        {
            //Implementer
            return "Info om Menuitem";
        }

        //public abstract string PrintInfo();
        
        public override string ToString()
        {
            //Implementer
            return base.ToString();
        }

    }
}
