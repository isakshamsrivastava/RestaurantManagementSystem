using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.AllUserControls
{
    public partial class AddItem : UserControl
    {
        function fn = new function();
        string query;

        public AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('"+txtItemName.Text+ "','" + txtCategory.Text + "', " + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();

        }

        private void AddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
