using System;
using System.Data;
using System.Windows.Forms;

namespace TJ_Lanka_PLC_PLM
{
    public partial class Summery : Form
    {

        private readonly function fn = new function();
        String query;

        public Summery()
        {
            InitializeComponent();
        }

        private void Summery_Load(object sender, EventArgs e)
        {
            loadClientData();
            loadOrderData();
        }

        public void loadClientData()
        {
            query = "select * from client_details";
            DataSet ds = fn.getData(query);
            clientDGV.DataSource = ds.Tables[0];
        }

        public void loadOrderData()
        {
            query = "select * from Order_details";
            DataSet ds = fn.getData(query);
            orderDGV.DataSource = ds.Tables[0];
        }

        private void clientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
