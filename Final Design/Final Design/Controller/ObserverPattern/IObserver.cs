using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.ObserverPattern
{
    public interface IObserver
    {
        void update(string notification);
    }
}
