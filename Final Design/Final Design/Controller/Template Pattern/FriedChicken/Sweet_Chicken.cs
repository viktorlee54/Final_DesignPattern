using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern.FriedChicken
{
    public class Sweet_Chicken : ChickenTemplate
    {
        public override String prepairMaterial()
        {
            return "Preparing chicken , sugar";
        }
        public override String preprocessing()
        {
            Console.WriteLine("Preprocessing");
            return "Preprocessing";
        }
        public override String processing()
        {
            Console.WriteLine("Processing");
            return "cooking";
        }
        public override String taste()
        {
            return "Finish Sweet Chicken";
        }
    }
}
