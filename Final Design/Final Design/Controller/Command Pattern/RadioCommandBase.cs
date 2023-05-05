﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.Command_Pattern
{
    public abstract class CheckBoxCommandBase
    {
        protected CheckBox[] items;
        protected CheckBoxCommandBase(params CheckBox[] items)
        {
            this.items = items;

        }
        public abstract void execute();

    }
    class ToppingOn : CheckBoxCommandBase
    {

        public ToppingOn(params CheckBox[] items) : base(items) { }

        public override void execute()
        {
            foreach (var button in items)
            {
                button.Checked = true;
            }
        }
    }
    class ToppingOff : CheckBoxCommandBase
    {
        public ToppingOff(params CheckBox[] items) : base(items)
        {

        }

        public override void execute()
        {
            throw new NotImplementedException();
        }
    }
    class CheckboxEnableCmd : CheckBoxCommandBase
    {
        public CheckboxEnableCmd(params CheckBox[] items) : base(items) { 
            
        }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Checked = true;
            }
        }
    }
    class CheckboxDisableCmd: CheckBoxCommandBase
    {
        public CheckboxDisableCmd(params CheckBox[] items) : base() { }

        public override void execute()
        {
            foreach(var button in items)
            {
                button.Checked = false;  
            }
        }
    }
}
