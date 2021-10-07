using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                btnUpdateItems.Hide();
            }
            else if(user == "Admin")
            {
                btnAddItems.Show();
                btnRemoveItems.Show();
                btnUpdateItems.Show();
            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addItem1.Visible = true;
            addItem1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addItem1.Visible = false;
            placeOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            placeOrder1.Visible = true;
            placeOrder1.BringToFront();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }
    }
}
