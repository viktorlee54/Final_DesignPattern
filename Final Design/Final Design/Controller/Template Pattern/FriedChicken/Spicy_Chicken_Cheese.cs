using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern.FriedChicken
{
    public class Spicy_Chicken_Cheese : ChickenTemplate
    {
        public override String prepairMaterial()
        {
            return "Preparing cheese, chicken, pepper";
        }
        public override String preprocessing()
        {
            return "Preprocessing";
        }
        public override String processing()
        {
            return "cooking";
        }
        public override String taste()
        {
            return "Finish Spicy Chicken with Cheese";
        }
    }
}