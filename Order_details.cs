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

        public void loadOrderData()
        {
            query = "select * from Order_details";
            DataSet ds = fn.getData(query);
            DGVorder.DataSource = ds.Tables[0];
        }


        private void Order_details_Load(object sender, EventArgs e)
        {
            loadOrderData();
            ClientID(false);
            BrandDropDown(false);
            New(false);
            SubmitButton(false);
            UpdateButton(false);
            SearchBrandDropDown(true);

        }


        private void SubmitBtn1_Click_1(object sender, EventArgs e)
        {

            if (OrderPriorityTxtBox.Text != "" && OrderCategoryDropDown.Text != "" && DueDateBox.Text != "" && UnitPriceTxtBox.Text != "" && QuantityTxtBox.Text != "" && DiscountTxtBox.Text != "")
            {

                query = "insert into Order_details (client_id,order_priority,order_category,brand,due_date,unit_price,quantity,discount) values ('" + clientIdTxtBox.Text + "','" + OrderPriorityTxtBox.Text + "','" + OrderCategoryDropDown.Text + "','" + brandDropDown.Text + "','" + DueDateBox.Value + "','" + UnitPriceTxtBox.Text + "','" + QuantityTxtBox.Text + "','" + DiscountTxtBox.Text + "')";
                fn.setData(query);
                loadOrderData();
                ClearAll();

                double unitPrice = double.Parse(DGVorder.Rows[this.rowIndex].Cells[6].Value.ToString());
                double quantity = double.Parse(DGVorder.Rows[this.rowIndex].Cells[7].Value.ToString());
                double discount = double.Parse(DGVorder.Rows[this.rowIndex].Cells[8].Value.ToString());


                double total = quantity * unitPrice;
                double netDiscount = (total / 100) * discount;
                totalTxtBox.Text = (total - netDiscount).ToString();

                query = "insert into Order_details (total) values ('" + totalTxtBox.Text + "')";
                fn.setData(query);
                loadOrderData();
                ClearAll();

                New(false);
                SubmitButton(false);
                UpdateButton(false);
                ClientID(false);
                BrandDropDown(false);
                SearchBrandDropDown(true);
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
            DueDateBox.ResetText();
            brandDropDown.ResetText();
            clientIdTxtBox.Clear();
            UnitPriceTxtBox.Clear();
            QuantityTxtBox.Clear();
            DiscountTxtBox.Clear();
            totalTxtBox.Clear();

        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            Client_details cd = new Client_details();
            this.Hide();
            cd.Show();
        }



        //query = "select * from (select top 1 * from client_details order by [client_id] DESC) last";
        private void searchBrand_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClearAll();
            query = "select * from Order_details where brand like '" + searchBrand.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVorder.DataSource = ds.Tables[0];

        }

        private void New(bool value)
        {
            OrderPriorityTxtBox.Enabled = value;
            OrderCategoryDropDown.Enabled = value;
            DueDateBox.Enabled = value;
            UnitPriceTxtBox.Enabled = value;
            QuantityTxtBox.Enabled = value;
            DiscountTxtBox.Enabled = value;
            totalTxtBox.Enabled = value;

        }
        private void SubmitButton(bool value)
        {
            SubmitBtn.Enabled = value;
        }

        private void ClientID(bool value)
        {
            clientIdTxtBox.Enabled = value;
        }
        private void UpdateButton(bool value)
        {
            btnUpdateOrder.Enabled = value;
        }
        private void BrandDropDown(bool value)
        {
            brandDropDown.Enabled = value;
        }
        private void SearchBrandDropDown(bool value)
        {
            searchBrand.Enabled = value;
        }




        int OrderId;

        public int rowIndex { get; private set; }

        private void DGVorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            New(false);
            UpdateButton(false);

            int clientID = int.Parse(DGVorder.Rows[this.rowIndex].Cells[1].Value.ToString());
            String brand = DGVorder.Rows[this.rowIndex].Cells[4].Value.ToString();

            clientIdTxtBox.Text = clientID.ToString();
            brandDropDown.Text = brand;

            ClientID(false);
            SearchBrandDropDown(false);
            BrandDropDown(false);
            SubmitButton(true);
            New(true);

        }

        private void DGVorder_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DGVorder.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DGVorder.CurrentCell = this.DGVorder.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.DGVorder, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
                OrderId = int.Parse(DGVorder.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
            if (!this.DGVorder.Rows[this.rowIndex].IsNewRow)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this Order?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.DGVorder.Rows.RemoveAt(this.rowIndex);
                    query = "delete from Order_details where order_id =" + OrderId + "";
                    fn.setData(query);
                    loadOrderData();
                }
                else if (DialogResult == DialogResult.No)
                {
                    loadOrderData();
                }

            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            query = "update Order_details set order_priority = '" + OrderPriorityTxtBox.Text + "', order_category = '" + OrderCategoryDropDown.Text + "', due_date = '" + DueDateBox.Text + "', unit_price = '" + UnitPriceTxtBox.Text + "', quantity= '" + QuantityTxtBox.Text + "', discount= '" + DiscountTxtBox.Text + "', total= '" + totalTxtBox.Text + "' where order_id= " + OrderId + "";
            fn.setData(query);
            loadOrderData();
            ClearAll();
        }

        private void editOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
            if (!this.DGVorder.Rows[this.rowIndex].IsNewRow)
            {
                UpdateButton(false);
                BrandDropDown(false);
                New(true);
                OrderId = int.Parse(DGVorder.Rows[this.rowIndex].Cells[0].Value.ToString());
                int clientID = int.Parse(DGVorder.Rows[this.rowIndex].Cells[1].Value.ToString());
                String orderPriority = DGVorder.Rows[this.rowIndex].Cells[2].Value.ToString();
                String orderCategory = DGVorder.Rows[this.rowIndex].Cells[3].Value.ToString();
                String brand = DGVorder.Rows[this.rowIndex].Cells[4].Value.ToString();
                String dueDate = DGVorder.Rows[this.rowIndex].Cells[5].Value.ToString();
                double unitPrice = double.Parse(DGVorder.Rows[this.rowIndex].Cells[6].Value.ToString());
                double quantity = double.Parse(DGVorder.Rows[this.rowIndex].Cells[7].Value.ToString());
                double discount = double.Parse(DGVorder.Rows[this.rowIndex].Cells[8].Value.ToString());
                double total = double.Parse(DGVorder.Rows[this.rowIndex].Cells[9].Value.ToString());

                clientIdTxtBox.Text = clientID.ToString();
                brandDropDown.Text = brand;
                OrderPriorityTxtBox.Text = orderPriority;
                OrderCategoryDropDown.Text = orderCategory;
                //priceTextBox.Text = price.ToString();
                DueDateBox.Text = dueDate.ToString();
                UnitPriceTxtBox.Text = unitPrice.ToString();
                QuantityTxtBox.Text = quantity.ToString();
                DiscountTxtBox.Text = discount.ToString();
                totalTxtBox.Text = total.ToString();


                UpdateButton(true);
                BrandDropDown(false);
                ClientID(false);
            }
        }


    }

}

