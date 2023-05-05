using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.State_Pattern
{
    public class ReservedTableState : ITableState
    {
        public void Enter(Table table)
        {
            //Console.WriteLine("Bàn đã được đặt trước, vui lòng đợi cho đến khi được phục vụ.");
        }
        public void Reserve(Table table)
        {
            //Console.WriteLine("Bàn đã được đặt trước, không thể đặt lại.");
        }

        public void Leave(Table table)
        {
           // Console.WriteLine("Bàn trống rồi, không có khách nào đang sử dụng.");
            table.state = new EmptyTableState();
            
        }

        public void SetColor(Button table)
        {
            table.BackColor = Color.Yellow;
        }

    }
}
