using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.State_Pattern
{
    public interface ITableState
    {
        void Enter(Table table);
        void Reserve(Table table);
        void Leave(Table table);
        void SetColor(Button table);
    }

}
