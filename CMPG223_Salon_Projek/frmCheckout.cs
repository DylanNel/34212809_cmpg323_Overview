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
    public partial class frmCheckout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        int Selected = 0;
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if the user selected a record to remove//
           /* if (Selected != 0)
            {
                SqlCommand cmd = new SqlCommand("delete tblAppointment where appointmentID=@selected", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selected", Selected + 1);
                cmd.ExecuteNonQuery();
                con.Close();
                string sql = "SELECT * FROM tblAppointment WHERE appointmentID LIKE '%" + txtSearch.Text + "%' or appointmentDate LIKE '%" + txtSearch.Text + "%' or appointmentTime LIKE '%" + txtSearch.Text + "%' or clientName LIKE '%" + txtSearch.Text + "%' or clientSurname LIKE '%" + txtSearch.Text + "%' ORDER BY appointmentID";
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
            }*/
        }

        private void DGView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected = DGView.CurrentRow.Index;
        }
    }
}
