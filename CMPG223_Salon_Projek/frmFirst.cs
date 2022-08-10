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
    public partial class frmLogin : Form
    {
        //global variable declaration//
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        public bool falseLogAdmin = false;
        public bool falseLogEmployee = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //variable declaration//
            SqlDataAdapter adap;
            SqlCommand command;
            SqlDataReader reader;
            String sql, Name="", Surname="", sqlGetName;

            //if admin signs in//
            //try-catch for error catching//
            try
            {
                //execute sql to display reports from database//
                con.Open();
                sql = "SELECT * FROM tblAdmins WHERE adminID = '" + txtUsername.Text.Trim() + "' and adminPassword = '" + txtPassword.Text.Trim() + "'";
                adap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                sqlGetName = "SELECT * FROM tblAdmins WHERE adminID = '" + txtUsername.Text.Trim() + "'";
                command = new SqlCommand(sqlGetName, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Name = reader.GetValue(2).ToString();
                    Surname = reader.GetValue(3).ToString();
                }

                //if valid info were entered//
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    frmAdmin fAdmin = new frmAdmin();
                    fAdmin.Show();
                    MessageBox.Show("Welcome " + Name + " " + Surname + " (Admin)");
                    falseLogAdmin = false;
                }
                //if invalid info were entered//
                else
                {
                    falseLogAdmin = true;
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred while logging in with your credentials");
                this.Height = 200;
                this.Width = 600;
                panel1.Height = 145;

                lblUsername.Hide();
                lblPassword.Hide();
                txtUsername.Hide();
                txtPassword.Hide();
                btnContinue.Hide();

            }
            //if employee signs in//
            //try-catch for error catching//
            try
            {
                con.Open();
                sql = "SELECT * FROM tblEmployees WHERE employeeID = '" + txtUsername.Text.Trim() + "' and employeePassword = '"+txtPassword.Text.Trim()+"'";
                adap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                sqlGetName = "SELECT * FROM tblEmployees WHERE employeeID = '" + txtUsername.Text.Trim() + "'";
                command = new SqlCommand(sqlGetName, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Name = reader.GetValue(2).ToString();
                    Surname = reader.GetValue(3).ToString();
                }

                //if valid info were entered//
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    frmEmployee fEmployee = new frmEmployee();
                    fEmployee.Show();
                    MessageBox.Show("Welcome " + Name + " " + Surname + " (Employee)");
                    falseLogEmployee = false;
                }
                //if invalid info were entered//
                else
                {
                    falseLogEmployee = true;
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred while logging in with your credentials");
               
            }

            if (falseLogEmployee==true && falseLogAdmin ==true)
            {
                MessageBox.Show("Please make sure you have entered valid data");
                txtUsername.Focus();
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }

        private void rBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnEmployee_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
    
}
