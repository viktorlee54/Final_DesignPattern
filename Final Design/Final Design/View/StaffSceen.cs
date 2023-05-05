using Final_Design.Controller.ObserverPattern;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Final_Design.Model;
using System.Diagnostics;
using System.Xml.Linq;

namespace Final_Design.View
{
    public partial class StaffSceen : Form
    {
        String strCon = ConfigurationManager.ConnectionStrings["SQLCon"].ConnectionString;
        public StaffSceen()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            if (cbNoticeType.Text== "Public Notification")
            {
                subject.RegisterObserver(new PublicNotification(lblPublicNotice));
                subject.Notify(txtNotification.Text);
            }
            else if (cbNoticeType.Text == "Private Notification")
            {
                subject.RegisterObserver(new PrivateNotification(lblPrivateNotice));
                subject.Notify(txtNotification.Text);
            }
        }
        public void LoadStaff()
        {

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            String sql = "SELECT * FROM Staff";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgStaff.DataSource = dt;
        }
        private bool addStaff(Staff staff)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO Staff( _name, _position)  VALUES( @name,@price)";
                command.Parameters.AddWithValue("@name", staff.Name);
                command.Parameters.AddWithValue("@price", staff.Position);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        private void btnAddstaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Name = txtStaffName.Text;
            staff.Position = txtStaffPos.Text;
            if (addStaff(staff))
            {
                MessageBox.Show("success");
                LoadStaff();
            }
        }
    }
}
