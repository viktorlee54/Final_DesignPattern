using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.Command_Pattern
{
    abstract class CommandBase
    {
        protected Button[] items;
        protected CommandBase(params Button[] items) {
                    this.items= items;
                }
        public abstract void execute();
    }
    class EnableCmd : CommandBase
    {
        public EnableCmd(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Enabled = true;
            }
        }
    }
    class DisableCmd : CommandBase
    {
        public DisableCmd(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Enabled = false;
            }
        }
    }
    class Defcolor : CommandBase
    {
        public Defcolor(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.BackColor = Color.Transparent;

            }

        }

    }
    class ButtonHide : CommandBase
    {
        public ButtonHide(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach(var button in items)
            {
                button.Hide();
            }
        }
    }
    class ButtonShow : CommandBase
    {
        public ButtonShow(params Button[] items) : base(items) { 
         
        }
        public override void execute()
        {
            foreach( var button in items)
            {
                button.Show();
            }
        }
    }
}

