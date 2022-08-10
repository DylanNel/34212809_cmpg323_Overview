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
    public partial class frmAdmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //if the admin wants to request reports//
            this.Hide();
            frmReports fReports = new frmReports();
            fReports.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            //if the admin wants to maintain clients//
            this.Hide();
            frmClients fClients = new frmClients();
            fClients.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //if the admin want to do a checkout//
            this.Hide();
            frmCheckout fCheckout = new frmCheckout();
            fCheckout.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            //if the admin wants to maintain appointments//
            this.Hide();
            frmAppointment fAppointment = new frmAppointment();
            fAppointment.Show();
        }

        private void btnMaintainTreatments_Click(object sender, EventArgs e)
        {
            //if the admin wants to maintain treatments//
            this.Hide();
            frmTreatments fTreatments = new frmTreatments();
            fTreatments.Show();
        }

        private void btnMaintainProducts_Click(object sender, EventArgs e)
        {
            //if the admin wants to maintain products//
            this.Hide();
            frmProducts fProducts = new frmProducts();
            fProducts.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if the admin wants to add another user//
            this.Hide();
            frmMaintainUsers fAdd = new frmMaintainUsers();
            fAdd.Show();
        }
    }
}
