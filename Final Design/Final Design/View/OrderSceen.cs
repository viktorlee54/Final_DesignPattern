using Final_Design.Controller.DecoratorPattern.Chicken;
using Final_Design.Controller.DecoratorPattern.MilkTea;
using Final_Design.Controller.Strategy_Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Design.View
{
    public partial class OrderSceen : Form
    {
        public OrderSceen()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(numBox.Value);
            String name = "";
            int total_price = Convert.ToInt32(txtTotal.Text);
            int price = 0;
            if (cbFood.Text.Equals("Sweet Chicken"))
            {
                Chicken chicken = new SweetChicken();
                if (cbFoodToping.Text.Equals("Onion"))
                {
                    chicken = new Onion(chicken);
                }
                if (cbFoodToping.Text.Equals("Cheese"))
                {
                    chicken = new Cheese(chicken);
                }
                name = chicken.MakeChicken();
                price = chicken.GetPrice();
                total_price = total_price + chicken.GetPrice();
            }
            if (cbFood.Text.Equals("Spicy Chicken"))
            {
                Chicken chicken = new SpicyChicken();
                if (cbFoodToping.Text.Equals("Onion"))
                {
                    chicken = new Onion(chicken);   
                }
                if (cbFoodToping.Text.Equals("Cheese"))
                {
                    chicken = new Cheese(chicken);
                }
                name = chicken.MakeChicken();
                price = chicken.GetPrice();
                total_price = total_price + chicken.GetPrice();
            }
            if (cbDrink.Text.Equals("Traditional MilkTea"))
            {
                MilkTea milkTea = new TraditionalMilkTea();
                if (cbDrinkToping.Text.Equals("Flan"))
                {
                    milkTea = new Flan(milkTea);
                }
                if(cbDrinkToping.Text.Equals("Strawbery"))
                {
                    milkTea = new Strawbery(milkTea);
                }
                name = milkTea.MakeMilkTea();
                price = milkTea.GetPrice();
                total_price = total_price + milkTea.GetPrice();
            }
            if (cbDrink.Text.Equals("Honey MilkTea"))
            {
                MilkTea milkTea = new HoneyMilkTea();
                if (cbDrinkToping.Text.Equals("Flan"))
                {
                    milkTea = new Flan(milkTea);
                }
                if (cbDrinkToping.Text.Equals("Strawbery"))
                {
                    milkTea = new Strawbery(milkTea);
                }
                name = milkTea.MakeMilkTea();
                price = milkTea.GetPrice();
                total_price = total_price + milkTea.GetPrice();
            }
            if (val > 0)
            {
                dtgFood.Rows.Add(name,val,price);
                txtTotal.Text = Convert.ToString(total_price);
            }
            
        }

        private void cbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFood.Text = "";
            cbFoodToping.Text = "";
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDrink.Text = "";
            cbDrinkToping.Text = "";
        }

        private void dtgFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colDel.Index)
            {
                int val = Convert.ToInt32(dtgFood.Rows[e.RowIndex].Cells[2].Value);
                int total = Convert.ToInt32(txtTotal.Text);
                total = total - val;
                txtTotal.Text = total.ToString();
                dtgFood.Rows.RemoveAt(e.RowIndex);
            }         
        }

        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            rdATM.Checked = false;
            rdMomo.Checked = false;
        }

        private void rdATM_CheckedChanged(object sender, EventArgs e)
        {
            rdCash.Checked = false;
            rdMomo.Checked = false;
        }

        private void rdMomo_CheckedChanged(object sender, EventArgs e)
        {
            rdCash.Checked = false;
            rdATM.Checked = false;   
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int must_pay = Convert.ToInt32(txtTotal.Text);
            int receive = Convert.ToInt32(numMoneyReceive.Value);
            Context context = new Context();
            if (!rdATM.Checked &&!rdCash.Checked && !rdMomo.Checked) {
                MessageBox.Show("Please choose payment");
            }
            else
            {
                if (rdATM.Checked)
                {
                    context.SetPayment(new ByATM());
                    MessageBox.Show(context.methodPay());
                    
                }
                if (rdCash.Checked)
                {
                    context.SetPayment(new ByCash());
                    int pay = context.pay(must_pay,receive);
                    String notice = "";
                    if (pay<0)
                    {
                        notice = "not enough money";
                    }
                    else if (pay>0)
                    {
                        notice = "exchange: "+pay;
                        lblExchange.Text = pay.ToString();
                    }
                    MessageBox.Show(context.methodPay()+"\n "+notice);
                }
                if (rdMomo.Checked)
                {
                    context.SetPayment(new MoMo());
                    MessageBox.Show(context.methodPay());
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDrink.Text = "";
            cbDrinkToping.Text = "";
            cbFood.Text = "";
            cbFoodToping.Text = "";
            numBox.Value = 0;
            numMoneyReceive.Value = 0;
            txtTotal.Text = "0";
            dtgFood.Rows.Clear();
            rdATM.Checked = false;
            rdCash.Checked = false;
            rdMomo.Checked = false;
        }
    }
}
