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

        public void LoadOrderData()
        {
            query = "select * from Order_details";
            DataSet ds = fn.getData(query);
            NewOrderDGV.DataSource = ds.Tables[0];
        }

        public void LoadCid()
        {
            query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
            DataSet ds = fn.getData(query);
            NewclientIdTxtBox.Text = ds.Tables[0].Rows[0]["client_id"].ToString();
        }

        public void LoadBrand()
        {
            query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
            DataSet ds = fn.getData(query);
            NewbrandDropDown.Text = ds.Tables[0].Rows[0]["company"].ToString();
        }


        public int rowIndex { get; private set; }

        private void NewSubmitBtn_Click(object sender, EventArgs e)
        {
            if (NewOrderPriorityTxtBox.Text != "" && NewOrderCategoryDropDown.Text != "" && NewDueDateBox.Text != "" && NewUnitPriceTxtBox.Text != "" && NewQuantityTxtBox.Text != "" && NewDiscountTxtBox.Text != "" && NewStatusTxtBox.Text != "")
            {
                double unitPrice = double.Parse(NewUnitPriceTxtBox.Text.ToString());
                int quantity = int.Parse(NewQuantityTxtBox.Text.ToString());
                double discount = double.Parse(NewDiscountTxtBox.Text.ToString());


                double total = quantity * unitPrice;
                double netDiscount = (total / 100) * discount;
                double gTotal = (total - netDiscount);
                double NetValue = Math.Round((double)gTotal, 2);
                totalTxtBox.Text = "Rs. " + NetValue;

                MessageBox.Show("The total of the current order is '" + totalTxtBox.Text + "'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query = "insert into Order_details (client_id,order_priority,order_category,brand,due_date,unit_price,quantity,discount,total,status) values ('" + NewclientIdTxtBox.Text + "','" + NewOrderPriorityTxtBox.Text + "','" + NewOrderCategoryDropDown.Text + "','" + NewbrandDropDown.Text + "','" + NewDueDateBox.Value + "','" + NewUnitPriceTxtBox.Text + "','" + NewQuantityTxtBox.Text + "','" + NewDiscountTxtBox.Text + "','" + totalTxtBox.Text + "', '" + NewStatusTxtBox.Text + "')";

                fn.setData(query);

                LoadOrderData();
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
            NewStatusTxtBox.ResetText();

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
            NewStatusTxtBox.Enabled = value;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            LoadOrderData();
            LoadCid();
            LoadBrand();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NewOrderPriorityTxtBox.SelectedIndex = -1;
            NewOrderCategoryDropDown.SelectedIndex = -1;
            NewDueDateBox.ResetText();
            NewUnitPriceTxtBox.Clear();
            NewQuantityTxtBox.Clear();
            NewDiscountTxtBox.Clear();
            NewStatusTxtBox.ResetText();
        }
    }
}
