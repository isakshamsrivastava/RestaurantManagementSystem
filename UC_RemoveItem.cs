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
    public partial class UC_RemoveItem : UserControl
    {
        function fn = new function();
        string query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGridViewRemoveItem.DataSource = ds.Tables[0];
        }

        private void txtSearchRemoveItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchRemoveItem.Text + "%' ";
            DataSet ds = fn.getData(query);
            dataGridViewRemoveItem.DataSource = ds.Tables[0];
        }

        private void dataGridViewRemoveItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete Item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                int uid = int.Parse(dataGridViewRemoveItem.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where itemid = " + uid + "";
                fn.setData(query);
                loadData();
            }
        }

        private void UC_RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
