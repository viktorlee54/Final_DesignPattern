using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.Controller.State_Pattern
{
    public class OccupiedTableState : ITableState
    {
        public void Enter(Table table)
        {
            Console.WriteLine("Bàn đang được sử dụng, vui lòng chọn bàn khác.");
        }

        public void Reserve(Table table)
        {
            Console.WriteLine("Bàn đã được đặt trước, vui lòng chọn bàn khác.");
        }

        public void Leave(Table table)
        {
            Console.WriteLine("Bàn trống rồi, không có khách nào đang sử dụng.");

        }
        public void SetColor(Button table)
        {
            table.BackColor = Color.Red;
        }
    }
}