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
            SearchBox(true);
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
            SearchBrandTxtbox.Enabled = value;
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
            CompanyTxtBox.ResetText();
            CompanyTxtBox.ResetText();
            AddressTxtBox.Clear();
            ContactTxtBox.Clear();
            EmailTxtBox.Clear();
            //SearchBrandTxtbox.ResetText();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                New(true);
                BtnSubmit(true);
                BtnUpdate(false);
                SearchBox(false);


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
                Refresh();
                ClearAll();

                NewOrder od = new NewOrder();
                this.Hide();
                od.Show();

            }

            else
            {
                MessageBox.Show("All the details should be filled in the relevent field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            query = "update client_details set company = '" + CompanyTxtBox.Text + "', contact = '" + ContactTxtBox.Text + "', address = '" + AddressTxtBox.Text + "', email = '" + EmailTxtBox.Text + "', client_name= '" + ClientNameTxtBox.Text + "' where client_id= " + ClientId + "";
            fn.setData(query);
            loadClientData();
            New(false);
            SearchBox(true);
            BtnSubmit(false);
            BtnUpdate(false);
            ClearAll();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.DGVclient.Rows[this.rowIndex].IsNewRow)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete Client?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.DGVclient.Rows.RemoveAt(this.rowIndex);
                    query = "delete from client_details where client_id =" + ClientId + "";
                    fn.setData(query);
                    loadClientData();
                }
                else if (DialogResult == DialogResult.No)
                {
                    loadClientData();
                }

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

        int ClientId;
        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBox(true);
            BtnSubmit(false);
            BtnUpdate(false);

            if (!this.DGVclient.Rows[this.rowIndex].IsNewRow)
            {
                BtnUpdate(true);
                New(true);
                ClientId = int.Parse(DGVclient.Rows[this.rowIndex].Cells[0].Value.ToString());
                String client_name = DGVclient.Rows[this.rowIndex].Cells[1].Value.ToString();
                String company = DGVclient.Rows[this.rowIndex].Cells[2].Value.ToString();
                //int contact = int.Parse(DGVclient.Rows[e.RowIndex].Cells[3].Value.ToString());
                String contact = DGVclient.Rows[this.rowIndex].Cells[3].Value.ToString();
                String address = DGVclient.Rows[this.rowIndex].Cells[4].Value.ToString();
                String email = DGVclient.Rows[this.rowIndex].Cells[5].Value.ToString();


                ClientNameTxtBox.Text = client_name;
                CompanyTxtBox.Text = company;
                //priceTextBox.Text = price.ToString();
                ContactTxtBox.Text = contact;
                AddressTxtBox.Text = address;
                EmailTxtBox.Text = email;


                SearchBox(false);
            }

        }

        private void SearchBrandTxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from client_details where company like '" + SearchBrandTxtbox.Text + "%'";
            DataSet ds = fn.getData(query);
            DGVclient.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order_details fm = new Order_details();
            this.Hide();
            fm.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
