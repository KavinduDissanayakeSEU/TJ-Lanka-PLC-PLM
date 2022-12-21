using System;
using System.Data;
using System.Windows.Forms;

namespace TJ_Lanka_PLC_PLM
{
    public partial class Client_details : Form
    {
        private int rowIndex = 0;

        private readonly function fn = new function();
        String query;


        public Client_details()
        {
            InitializeComponent();
        }

        private void Client_details_Load(object sender, EventArgs e)
        {
            loadClientData();
            New(false);
            SearchBox(false);
            BtnSubmit(false);
            BtnUpdate(false);
        }

        public void loadClientData()
        {
            query = "select * from client_details";
            DataSet ds = fn.getData(query);
            DGVclient.DataSource = ds.Tables[0];
        }

        private void New(bool value)
        {
            ClientNameTxtBox.Enabled = value;
            CompanyTxtBox.Enabled = value;
            CompanyTxtBox.Enabled = value;
            AddressTxtBox.Enabled = value;
            ContactTxtBox.Enabled = value;
            EmailTxtBox.Enabled = value;
        }

        private void SearchBox(bool value)
        {
            searchTxtBox.Enabled = value;
        }


        private void BtnSubmit(bool value)
        {
            SubmitBtn.Enabled = value;
        }

        private void BtnUpdate(bool value)
        {
            updateBtn.Enabled = value;
        }

        public void ClearAll()
        {

            ClientNameTxtBox.Clear();
            CompanyTxtBox.Clear();
            CompanyTxtBox.Clear();
            AddressTxtBox.Clear();
            ContactTxtBox.Clear();
            EmailTxtBox.Clear();
            searchTxtBox.Clear();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                New(true);
                BtnSubmit(true);
                BtnUpdate(false);


            }
            catch (Exception)
            {
                MessageBox.Show("All the details should be filled in the relevent field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {

            if (ClientNameTxtBox.Text != "" && CompanyTxtBox.Text != "" && AddressTxtBox.Text != "" && ContactTxtBox.Text != "" && EmailTxtBox.Text != "")
            {
                query = "insert into client_details (client_name,company,address,contact,email) values ('" + ClientNameTxtBox.Text + "','" + CompanyTxtBox.Text + "','" + AddressTxtBox.Text + "','" + ContactTxtBox.Text + "','" + EmailTxtBox.Text + "')";
                fn.setData(query);
                SearchBox(false);
                loadClientData();
                ClearAll();

                /*Order_details od = new Order_details();
                this.Hide();
                od.Show();*/

            }

            else
            {
                MessageBox.Show("All the details should be filled in the relevent field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            New(false);
            SearchBox(true);
            BtnSubmit(false);
            BtnUpdate(true);

            MessageBox.Show("Type the client name in the Text Box to edit details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            query = "select * from client_details where client_name like '" + searchTxtBox.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVclient.DataSource = ds.Tables[0];
            ClearAll();
        }

        int ClientId;
        private void DGVclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            New(true);
            ClientId = int.Parse(DGVclient.Rows[e.RowIndex].Cells[0].Value.ToString());
            String client_name = DGVclient.Rows[e.RowIndex].Cells[1].Value.ToString();
            String company = DGVclient.Rows[e.RowIndex].Cells[2].Value.ToString();
            //int contact = int.Parse(DGVclient.Rows[e.RowIndex].Cells[3].Value.ToString());
            String contact = DGVclient.Rows[e.RowIndex].Cells[3].Value.ToString();
            String address = DGVclient.Rows[e.RowIndex].Cells[4].Value.ToString();
            String email = DGVclient.Rows[e.RowIndex].Cells[5].Value.ToString();


            ClientNameTxtBox.Text = client_name;
            CompanyTxtBox.Text = company;
            //priceTextBox.Text = price.ToString();
            ContactTxtBox.Text = contact;
            AddressTxtBox.Text = address;
            EmailTxtBox.Text = email;




        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from client_details where client_name like '" + searchTxtBox.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVclient.DataSource = ds.Tables[0];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            query = "update client_details set company = '" + CompanyTxtBox.Text + "', contact = '" + ContactTxtBox.Text + "', address = '" + AddressTxtBox.Text + "', email = '" + EmailTxtBox.Text + "', client_name= '" + ClientNameTxtBox.Text + "' where client_id= " + ClientId + "";
            fn.setData(query);
            loadClientData();
            ClearAll();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            New(false);
            SearchBox(true);
            BtnSubmit(false);
            BtnUpdate(false);


            MessageBox.Show("Click on the row that you want to remove client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.DGVclient.Rows[this.rowIndex].IsNewRow)
            {
                this.DGVclient.Rows.RemoveAt(this.rowIndex);
                query = "delete from client_details where client_id =" + ClientId + "";
                fn.setData(query);
                loadClientData();
            }
        }

        private void DGVclient_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DGVclient.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DGVclient.CurrentCell = this.DGVclient.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.DGVclient, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
                ClientId = int.Parse(DGVclient.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order_details fm = new Order_details();
            this.Hide();
            fm.Show();

        }
    }
}
