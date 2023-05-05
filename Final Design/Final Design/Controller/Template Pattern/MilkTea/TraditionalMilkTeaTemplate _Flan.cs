using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern.MilkTea
{
    public class TraditionalMilkTeaTemplate_Flan:MilkTeaTemplate
    {
        public override String prepairMaterial()
        {
            return "Prepare tea, milk, flan";
        }
        public override String preprocessing()
        {
            return "Preprocessing";
        }
        public override String processing()
        {
            return"cooking";
        }
        public override string taste()
        {
            return "Traditional Milk Tea with Flan";
        }
    }
}
