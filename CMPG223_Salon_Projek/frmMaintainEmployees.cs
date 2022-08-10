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
    public partial class frmMaintainEmployees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        int Selected = 0;
        public frmMaintainEmployees()
        {
            InitializeComponent();
        }

        private void frmMaintainEmployees_Load(object sender, EventArgs e)
        {
            //try to display the data from tblEmployees//
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblEmployees", con);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tblEmployees WHERE employeeID LIKE '%" + txtSearch.Text + "%' or employeePassword LIKE '%" + txtSearch.Text + "%' or employeeName LIKE '%" + txtSearch.Text + "%' or employeeSurname LIKE '%" + txtSearch.Text + "%' or employeeRank LIKE '%" + txtSearch.Text + "%'";
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if the user selected a record to remove//
            if (Selected != 0)
            {
                SqlCommand cmd = new SqlCommand("delete tblEmployees where employeeID=@selected", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selected", Selected + 1);
                cmd.ExecuteNonQuery();
                con.Close();
                string sql = "SELECT * FROM tblEmployees WHERE employeeID LIKE '%" + txtSearch.Text + "%' or employeePassword LIKE '%" + txtSearch.Text + "%' or employeeName LIKE '%" + txtSearch.Text + "%' or employeeSurname LIKE '%" + txtSearch.Text + "%' or employeeRank LIKE '%" + txtSearch.Text + "%' ORDER BY employeeID";
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
