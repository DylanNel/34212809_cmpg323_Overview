using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Salon_Projek
{
    public partial class frmProducts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        int Selected = 0;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckout fCheckout = new frmCheckout();
            fCheckout.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //try to display the data from tblProducts//
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblProducts", con);
                con.Open();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DGView.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("The data could not be displayed.");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tblProducts WHERE productID LIKE '%" + txtSearch.Text + "%' or productType LIKE '%" + txtSearch.Text + "%' or productDescription LIKE '%" + txtSearch.Text + "%' or productQuantity LIKE '%" + txtSearch.Text + "%' or productPrice LIKE '%" + txtSearch.Text + "%'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DGView.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("The data was not found.");
            }
            
        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if the user selected a record to remove//
            if (Selected != 0)
            {
                SqlCommand cmd = new SqlCommand("delete tblProducts where productID=@selected", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selected", Selected);
                cmd.ExecuteNonQuery();
                con.Close();
                string sql = "SELECT * FROM tblProducts WHERE productID LIKE '%" + txtSearch.Text + "%' or productType LIKE '%" + txtSearch.Text + "%' or productDescription LIKE '%" + txtSearch.Text + "%' or productQuantity LIKE '%" + txtSearch.Text + "%' or productPrice LIKE '%" + txtSearch.Text + "%' ORDER BY productID";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DGView.DataSource = dt;
                Selected = 0;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a user to remove");
            }
        }

        private void DGView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected = DGView.CurrentRow.Index;
        }
    }
}
