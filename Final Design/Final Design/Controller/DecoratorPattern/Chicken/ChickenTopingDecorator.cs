using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.Chicken
{
    public abstract class ChickenTopingDecorator : Chicken
    {
        protected Chicken chicken;
        public ChickenTopingDecorator(Chicken chicken)
        {
            this.chicken = chicken;
        }

        public virtual String MakeChicken()
        {
           return chicken.MakeChicken();
        }

        public virtual int GetPrice()
        {
            return chicken.GetPrice();
        }
    }
}
