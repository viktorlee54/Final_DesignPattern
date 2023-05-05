using Final_Design.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectDatabase()
        {

        }

        private void BttQuay_Click(object sender, EventArgs e)
        {
            KitchenSceen kitchenSceen = new KitchenSceen();
            kitchenSceen.Show();
            
        }

        private void bttNhanVien_Click(object sender, EventArgs e)
        {
            StaffSceen staffSceen = new StaffSceen();
            staffSceen.Show();
            

        }

        private void bttDatMon_Click(object sender, EventArgs e)
        {
            OrderSceen orderSceen = new OrderSceen();
            orderSceen.Show();
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bttBan_Click(object sender, EventArgs e)
        {
            TableManage tableManage = new TableManage();
            tableManage.Show();
        }
    }
}