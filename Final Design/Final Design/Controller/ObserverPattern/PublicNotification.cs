using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.ObserverPattern
{
    public class PublicNotification : IObserver
    {
        private Label label;

        public PublicNotification(Label label)
        {
            this.label = label;
        }

        public void update(string notification)
        {
            label.Text = notification;
        }
    }
}
