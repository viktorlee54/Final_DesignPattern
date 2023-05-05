using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.Chicken
{
    public class SpicyChicken : Chicken
    {
        public string MakeChicken()
        {
            return "Spicy Chicken";
        }
        public int GetPrice()
        {
            return 80000;
        }
    }
}
