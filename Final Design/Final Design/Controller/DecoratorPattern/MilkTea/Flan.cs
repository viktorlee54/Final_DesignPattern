using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.MilkTea
{
    public class Flan : MilkTeaTopingDecoration
    {
        public Flan(MilkTea milkTea) : base(milkTea)
        {
        }

        public override string MakeMilkTea()
        {
            return milkTea.MakeMilkTea() + " + Flan";
        }

        public override int GetPrice()
        {
            return milkTea.GetPrice() + 10000;
        }
    }
}