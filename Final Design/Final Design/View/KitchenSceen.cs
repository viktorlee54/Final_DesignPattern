using Final_Design.Controller.Template_Pattern;
using Final_Design.Controller.Template_Pattern.FriedChicken;
using Final_Design.Controller.Template_Pattern.MilkTea;
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
    public partial class KitchenSceen : Form
    {
        ChickenTemplate chic;
        MilkTeaTemplate milk;
        public KitchenSceen()
        {
            InitializeComponent();
        }


        private void btnSpicyChick_Click(object sender, EventArgs e)
        {
            chic = new Spicy_Chicken();
            chic.MakeFood(lblCookstate);
        }

        private void btnSpicyChickCheese_Click(object sender, EventArgs e)
        {
            chic = new Spicy_Chicken_Cheese();
            chic.MakeFood(lblCookstate);
        }

        private void btnHoneyMilkTeaStrawbery_Click(object sender, EventArgs e)
        {
            milk = new HoneyMilkTeaTemplate_Strawbery();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnHoneyMilkTeaFlan_Click(object sender, EventArgs e)
        {
            milk = new HoneyMilkTeaTemplate_Flan();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnHoneyMilkTea_Click(object sender, EventArgs e)
        {
            milk = new HoneyMilkTeaTemplate();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnTraditionalMilkTeaStrawbery_Click(object sender, EventArgs e)
        {
            milk = new TraditionalMilkTeaTemplate_Strawbery();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnTraditionalMilkTeaFlan_Click(object sender, EventArgs e)
        {
            milk = new TraditionalMilkTeaTemplate_Flan();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnTraditionalMilkTea_Click(object sender, EventArgs e)
        {
            milk = new TraditionalMilkTeaTemplate();
            milk.MakeMilkTea(lblCookstate);
        }

        private void btnSweetChickenOnion_Click(object sender, EventArgs e)
        {
            chic = new Sweet_Chicken_Onion();
            chic.MakeFood(lblCookstate);
        }

        private void btnSweetChickenCheese_Click(object sender, EventArgs e)
        {
            chic = new Sweet_Chicken_Cheese();
            chic.MakeFood(lblCookstate);
        }

        private void btnSweetChicken_Click(object sender, EventArgs e)
        {
            chic = new Sweet_Chicken();
            chic.MakeFood(lblCookstate);
        }

        private void btnSpicyChickenOnion_Click(object sender, EventArgs e)
        {
            chic = new Spicy_Chicken_Onion();
            chic.MakeFood(lblCookstate);
        }
    }
}   
