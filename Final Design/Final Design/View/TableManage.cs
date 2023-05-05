
using Final_Design.Controller.State_Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.View
{
    

    public partial class TableManage : Form
    {
       
        public TableManage()
        {
            InitializeComponent();
            
        }
        

        private void btnTableUpdate_Click(object sender, EventArgs e)
        {
            if (cbID.Text.Equals("1"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table1.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table1.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table1.BackColor = table.color;
                }
            }
            if (cbID.Text.Equals("2"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table2.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table2.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table2.BackColor = table.color;
                }
            }
            if (cbID.Text.Equals("3"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table3.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table3.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table3.BackColor = table.color;
                }
            }
            if (cbID.Text.Equals("4"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table4.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table4.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table4.BackColor = table.color;
                }
            }
            if (cbID.Text.Equals("5"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table5.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table5.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table5.BackColor = table.color;
                }
            }
            if (cbID.Text.Equals("6"))
            {
                if (cbStatus.Text.Equals("Empty"))
                {
                    Table table = new Table();
                    table.state = new EmptyTableState();
                    table.SetColor(table6);
                    table6.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Available"))
                {
                    Table table = new Table();
                    table.state = new OccupiedTableState();
                    table6.BackColor = table.color;
                }
                if (cbStatus.Text.Equals("Reserved"))
                {
                    Table table = new Table();
                    table.state = new ReservedTableState();
                    table6.BackColor = table.color;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
