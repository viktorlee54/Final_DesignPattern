using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.State_Pattern
{
    public class Table
    {
        public ITableState state { get; set; }
        public Color color { get; set; }
        public Table()
        {
            this.state = new EmptyTableState();
            this.color = Color.White;
        }

        public void Enter()
        {
            state.Enter(this);
        }

        public void Reserve()
        {
            state.Reserve(this);
        }

        public void Leave()
        {
            state.Leave(this);
        }

        public void SetColor(Button table)
        {
            table.BackColor = color;
            
        }
    }
}
