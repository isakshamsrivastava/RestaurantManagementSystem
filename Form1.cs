using RestaurantManagementSystem.AllUserControls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard("Guest");
            dashboard.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OperationsManager om = new OperationsManager();
            var result = om.validateLogin(txtUsername.Text,txtPassword.Text);
            if(result == "Admin")
            {
                Dashboard ds = new Dashboard(result);
                ds.Show();
                this.Hide();
            }
            else if(result == "")
            {
                MessageBox.Show("Please Enter Correct Username & Password", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
