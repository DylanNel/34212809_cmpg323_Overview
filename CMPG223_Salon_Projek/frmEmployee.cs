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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //if the employee wants to do a checkout//
            this.Hide();
            frmCheckout fCheckout = new frmCheckout();
            fCheckout.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            //if the employee wants to maintain clients//
            this.Hide();
            frmClients fClients = new frmClients();
            fClients.Show();
        }

        private void btnMaintainTreatments_Click(object sender, EventArgs e)
        {
            //if the employee wants to maintain treatments//
            this.Hide();
            frmTreatments fTreatments = new frmTreatments();
            fTreatments.Show();
        }

        private void btnMaintainProducts_Click(object sender, EventArgs e)
        {
            //if the employee wants to maintain products//
            this.Hide();
            frmProducts fProducts = new frmProducts();
            fProducts.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            //if the employee wants to maintain appointments//
            this.Hide();
            frmAppointment fAppointment = new frmAppointment();
            fAppointment.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if the employee wants to go back to the first form//
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
