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
    public partial class frmTreatments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        int Selected = 0;
        SqlDataAdapter adap;
        DataTable dt;
        public frmTreatments()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void frmTreatments_Load(object sender, EventArgs e)
        {
            //try to display the data from tblTreatment//
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblTreatment", con);
                con.Open();
                adap = new SqlDataAdapter(command);
                dt = new DataTable();
                adap.Fill(dt);
                DGView.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("The data could not be displayed.");
            }

        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tblTreatment WHERE treatmentID LIKE '%" + txtSearch.Text + "%' or treatmentType LIKE '%" + txtSearch.Text + "%' or treatmentPrice LIKE '%" + txtSearch.Text + "%'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                adap = new SqlDataAdapter(command);
                dt = new DataTable();
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
                SqlCommand cmd = new SqlCommand("delete tblTreatment where treatmentID=@selected", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selected", Selected);
                cmd.ExecuteNonQuery();
                con.Close();
                string sql = "SELECT * FROM tblTreatment WHERE treatmentID LIKE '%" + txtSearch.Text + "%' or treatmentType LIKE '%" + txtSearch.Text + "%' or treatmentPrice LIKE '%" + txtSearch.Text + "%' ORDER BY treatmentID";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                adap = new SqlDataAdapter(command);
                dt = new DataTable();
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
            Selected = DGView.CurrentRow.Index+1;
        }
    }
}
