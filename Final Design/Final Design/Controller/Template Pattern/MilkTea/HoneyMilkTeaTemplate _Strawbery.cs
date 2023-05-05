using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.Template_Pattern.MilkTea
{
    public class HoneyMilkTeaTemplate_Strawbery:MilkTeaTemplate
    {
        public override String prepairMaterial()
        {
            return "Prepare Prepare tea, milk, honey, strawbery";
        }
        public override String preprocessing()
        {
            return "Preprocessing";
        }
        public override String processing()
        {
            return "cooking";
        }
        public override string taste()
        {
            return "Honey Milk Tea with Strawbery";
        }
    }
}
