using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.Template_Pattern
{
    public abstract class ChickenTemplate
    {
        public abstract String prepairMaterial();
        public abstract String preprocessing();
        public abstract String processing();
        public abstract string taste();
        public  void MakeFood(Label label)
        {
            
            label.Text=prepairMaterial();
            Application.DoEvents();
            Thread.Sleep(1000);
            label.Text=preprocessing();
            Application.DoEvents();
            Thread.Sleep(2000);
            label.Text = processing();
            Application.DoEvents();
            Thread.Sleep(1000);
            label.Text = taste();
            MessageBox.Show("Finish");
        }
    }
}
