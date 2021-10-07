using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagementSystem.AllUserControls
{
    public partial class PlaceOrder : UserControl
    {

        function fn = new function();
        string query;

        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string category = comboCategory.Text;
        //    query = "select name from items where category = '" + category + "' ";
        //    DataSet ds = fn.getData(query);

        //    int i;
        //    for (i = 0; i < ds.Tables[0].Rows.Count; i++)

        //    }

        //}


        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = comboCategory.Text;
            query = "select name from items where category = '"+category+"' ";
            DataSet ds = fn.getData(query);

            int i;
            for(i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                //listBox1.Items.Add(ds.Tables[0].Rows[i]) ;
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString()) ;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'and name like '"+txtSearch.Text+"%' ";
            DataSet ds = fn.getData(query);

            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtQuantity.clear();
            txtQuantity.ResetText();

            txtTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            //text = listBox1.Items[]
            txtItemName.Text = text;
            query = "select price from items where name = '"+text+"' ";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            //long q = long.Parse(txtQuantity.Text);
            long q = long.Parse(txtQuantity.Value.ToString());
            long price = long.Parse(txtPrice.Text);
            OperationsManager pc = new OperationsManager();
            var result = pc.priceCalc(q, price);
            txtTotal.Text = result.ToString();  
        }

        

        int n = 0;
        int total = 0;
        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView.Rows[n].Cells[2].Value = txtQuantity.Text;
                dataGridView.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotal.Text = "Rs.  " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity should be 1.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //var index = e.RowIndex;
                //var row = dataGridView.Rows[e.RowIndex];
                //var cell = dataGridView.Rows[e.RowIndex].Cells[3];
                amount = int.Parse(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                try
                {
                    dataGridView.Rows.RemoveAt(this.dataGridView.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            total -= amount;
            labelTotal.Text = "Rs. " + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + labelTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView);
            total = 0;
            dataGridView.Rows.Clear();
            labelTotal.Text = "Rs.  " + total;
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    DGVPrinter printer = new DGVPrinter();
        //    printer.Title = "Customer Bill";
        //    
        //    printer.Footer = "Total Payable Amount : " + labelTotal.Text;
        //    printer.PrintDataGridView(dataGridView);
        //    total = 0;
        //    dataGridView.Rows.Clear();
        //}


        //private void btnPrint_Click(object sender, EventArgs e)
        //    {
        //        DGVPrinter printer = new DGVPrinter();
        //        printer.Title = "Customer Bill";
        //        printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
        //        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        //        printer.PageNumbers = true;
        //        printer.PageNumberInHeader = false;
        //        printer.HeaderCellAlignment = StringAlignment.Near;
        //        printer.Footer = "Total Payable Amount : " + labelTotal.Text;
        //        printer.FooterSpacing = 15;
        //        printer.PrintDataGridView(dataGridView);
        //        total = 0;
        //        dataGridView.Rows.Clear();
        //        labelTotal.Text = "Rs.  " + total;
        //    }
    }
}
