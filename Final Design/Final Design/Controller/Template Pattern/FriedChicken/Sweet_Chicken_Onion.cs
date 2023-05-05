using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern.FriedChicken
{
    public class Sweet_Chicken_Onion:ChickenTemplate
    {
        public override String prepairMaterial()
        {
            return "Preparing chicken, onion, sugar";
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
            return "Finish Sweet Chicken with Onion";
        }
    }
}

