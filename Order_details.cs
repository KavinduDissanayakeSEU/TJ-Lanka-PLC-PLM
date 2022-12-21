using System;
using System.Data;
using System.Windows.Forms;

namespace TJ_Lanka_PLC_PLM
{
    public partial class Order_details : Form
    {
        private readonly function fn = new function();
        String query;

        public Order_details()
        {
            InitializeComponent();
        }

        public void loadClientData()
        {
            query = "select * from Order_details";
            DataSet ds = fn.getData(query);
            DGVorder.DataSource = ds.Tables[0];
        }



        private void Order_details_Load(object sender, EventArgs e)
        {
            loadClientData();

            //query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
            //DataSet ds = fn.getData(query);
            //orderIdTxtBox.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void SubmitBtn1_Click_1(object sender, EventArgs e)
        {


            if (OrderPriorityTxtBox.Text != "" && OrderCategoryDropDown.Text != "" && clientIdTxtBox.Text != "" && DueDateBox.Text != "" && UnitPriceTxtBox.Text != "" && QuantityTxtBox.Text != "" && DiscountTxtBox.Text != "")
            {
                query = "insert into order_details (client_id,order_priority,order_category,brand,due_date,unit_price,quantity,discount) values ('" + clientIdTxtBox.Text + "','" + OrderPriorityTxtBox.Text + "','" + OrderCategoryDropDown.Text + "','" + brandDropDown.Text + "','" + DueDateBox.MaxDate + "','" + UnitPriceTxtBox.Text + "','" + QuantityTxtBox.Text + "','" + DiscountTxtBox.Text + "')";
                fn.setData(query);

                Summery sm = new Summery();
                this.Hide();
                sm.Show();

                ClearAll();
            }
            else
            {
                MessageBox.Show("All the details should be filled in the relevent field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void ClearAll()
        {
            OrderPriorityTxtBox.SelectedIndex = -1;
            OrderCategoryDropDown.SelectedIndex = -1;
            clientIdTxtBox.Clear();
            DueDateBox.ResetText();
            UnitPriceTxtBox.Clear();
            QuantityTxtBox.Clear();
            DiscountTxtBox.Clear();

        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            Client_details cd = new Client_details();
            this.Hide();
            cd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from Order_details where brand like '" + brandDropDown.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVorder.DataSource = ds.Tables[0];
        }
    }
}

