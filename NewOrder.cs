using System;
using System.Data;
using System.Windows.Forms;

namespace TJ_Lanka_PLC_PLM
{
    public partial class NewOrder : Form
    {
        private readonly function fn = new function();
        String query;
        public NewOrder()
        {
            InitializeComponent();
        }

        public void loadOrderData()
        {
            query = "select * from Order_details";
            DataSet ds = fn.getData(query);
            NewOrderDGV.DataSource = ds.Tables[0];
        }

        public void loadCid()
        {
            query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
            DataSet ds = fn.getData(query);
            NewclientIdTxtBox.Text = ds.Tables[0].Rows[0]["client_id"].ToString();
        }

        public void loadBrand()
        {
            query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
            DataSet ds = fn.getData(query);
            NewbrandDropDown.Text = ds.Tables[0].Rows[0]["company"].ToString();
        }



        private void NewSubmitBtn_Click(object sender, EventArgs e)
        {
            if (NewOrderPriorityTxtBox.Text != "" && NewOrderCategoryDropDown.Text != "" && NewDueDateBox.Text != "" && NewUnitPriceTxtBox.Text != "" && NewQuantityTxtBox.Text != "" && NewDiscountTxtBox.Text != "")
            {

                query = "insert into Order_details (client_id,order_priority,order_category,brand,due_date,unit_price,quantity,discount) values ('" + NewclientIdTxtBox.Text + "','" + NewOrderPriorityTxtBox.Text + "','" + NewOrderCategoryDropDown.Text + "','" + NewbrandDropDown.Text + "','" + NewDueDateBox.Value + "','" + NewUnitPriceTxtBox.Text + "','" + NewQuantityTxtBox.Text + "','" + NewDiscountTxtBox.Text + "')";
                fn.setData(query);
                loadOrderData();
                ClearAll();
                New(false);

                Order_details fm = new Order_details();
                this.Hide();
                fm.Show();

            }
            else
            {
                MessageBox.Show("All the details should be filled in the relevent field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            NewOrderPriorityTxtBox.SelectedIndex = -1;
            NewOrderCategoryDropDown.SelectedIndex = -1;
            NewDueDateBox.ResetText();
            NewbrandDropDown.ResetText();
            NewclientIdTxtBox.Clear();
            NewUnitPriceTxtBox.Clear();
            NewQuantityTxtBox.Clear();
            NewDiscountTxtBox.Clear();

        }

        private void New(bool value)
        {
            NewclientIdTxtBox.Enabled = value;
            NewOrderPriorityTxtBox.Enabled = value;
            NewOrderCategoryDropDown.Enabled = value;
            NewDueDateBox.Enabled = value;
            NewbrandDropDown.Enabled = value;
            NewUnitPriceTxtBox.Enabled = value;
            NewQuantityTxtBox.Enabled = value;
            NewDiscountTxtBox.Enabled = value;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            loadOrderData();
            loadCid();
            loadBrand();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NewOrderPriorityTxtBox.SelectedIndex = -1;
            NewOrderCategoryDropDown.SelectedIndex = -1;
            NewDueDateBox.ResetText();
            NewUnitPriceTxtBox.Clear();
            NewQuantityTxtBox.Clear();
            NewDiscountTxtBox.Clear();
        }
    }
}
