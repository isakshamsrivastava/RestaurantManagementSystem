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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        string query;

        public UC_UpdateItems()
        {
            InitializeComponent();
        }
        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            query = "select * from items";
            LoadData(query);
        }

        public void LoadData(string q)
        {
            DataSet ds = fn.getData(q);
            datagridview_Update.DataSource = ds.Tables[0];
        }

        private void txtSearchUpdate_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchUpdateItem.Text + "%'";
            LoadData(query);
        }

        int id;
        private void datagridview_Update_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(datagridview_Update.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = datagridview_Update.Rows[e.RowIndex].Cells[2].Value.ToString();
            string itemName = datagridview_Update.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(datagridview_Update.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtItemName.Text = itemName;
            txtPrice.Text = price.ToString();

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            query = "update items set name = '" + txtItemName.Text + "',category = '" + txtCategory.Text + "',price = "+ txtPrice.Text +" where itemid = "+id+" ";
            fn.setData(query);
            LoadData("select * from items");
            txtItemName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }
    }
}
