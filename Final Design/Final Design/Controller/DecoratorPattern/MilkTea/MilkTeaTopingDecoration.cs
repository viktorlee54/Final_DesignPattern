using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.MilkTea
{
    public abstract class MilkTeaTopingDecoration : MilkTea
    {
        protected MilkTea milkTea;
        public MilkTeaTopingDecoration(MilkTea milkTea)
        {
            this.milkTea = milkTea;
        }

        public virtual String MakeMilkTea()
        {
            return milkTea.MakeMilkTea();
        }

        public virtual int GetPrice()
        {
            return milkTea.GetPrice();
        }
    }
}

