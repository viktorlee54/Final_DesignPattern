using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern
{
    public class Spicy_Chicken : ChickenTemplate
    {
        public override String prepairMaterial()
        {
            return "Preparing chicken, pepper";
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
            return "Finish Spicy Chicken";
        }
        
    }
}


