using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.DecoratorPattern.Chicken
    
{
    public class Cheese : ChickenTopingDecorator
    {
        public Cheese(Chicken chicken) : base(chicken)
        {
        }

        public override String MakeChicken()
        {
            return chicken.MakeChicken() + " with Cheese";
        }

        public override int GetPrice()
        {
            return chicken.GetPrice() + 20000;
        }
    }
}
