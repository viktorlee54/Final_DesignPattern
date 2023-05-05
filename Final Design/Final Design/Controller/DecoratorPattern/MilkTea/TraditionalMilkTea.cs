using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.MilkTea
{
    public class TraditionalMilkTea:MilkTea
    {
        public string MakeMilkTea()
        {
            return "Traditional Milk Tea";
        }
        public int GetPrice()
        {
            return 20000;
        }
    }
}
