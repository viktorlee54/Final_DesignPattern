using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.Chicken
{
    public class SweetChicken : Chicken
    {
        public string MakeChicken()
        {
            return "Sweet Chicken";
        }
        public int GetPrice()
        {
            return 100000;
        }
    }
}