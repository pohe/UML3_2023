using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_2023
{
    public class Pizza: MenuItem
    {
        public Pizza(int number, 
            string name, 
            string description, 
            double price, 
            MenuType menutype, 
            bool isVegan, 
            bool isOrganic,
            bool deepPan) : base( number, 
                                    name, 
                                    description, 
                                    price, 
                                    menutype, 
                                    isVegan, 
                                    isOrganic)
        {
            //Implemter
        }

        public bool DeepPan { get; set; }

    }
}
