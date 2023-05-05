using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.MilkTea
{
    public class Strawbery:MilkTeaTopingDecoration
    {
        public Strawbery(MilkTea milkTea) : base(milkTea)
        {
        }

        public override string MakeMilkTea()
        {
            return milkTea.MakeMilkTea() + " + Strawbery";
        }

        public override int GetPrice()
        {
            return milkTea.GetPrice() + 15000;
        }
    }
}
