using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.State_Pattern
{
    public class EmptyTableState : ITableState
    {
        public void Enter(Table table)
        {
            Console.WriteLine("Bàn trống, khách hàng có thể ngồi vào.");
            table.state = new OccupiedTableState();
           
        }

        public void Reserve(Table table)
        {
            Console.WriteLine("Đặt bàn thành công.");
            table.state = new ReservedTableState();
          
        }

        public void Leave(Table table)
        {
            Console.WriteLine("Bàn trống rồi, không có khách nào đang sử dụng.");
        }

        public void SetColor(Button table)
        {
            table.BackColor = Color.White;
        }
    }

}

