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
    public partial class frmMaintainUsers : Form
    {
        //global variable declaration//
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST;Initial Catalog=SalonDB;Integrated Security=True");
        public bool admin = false;
        public bool employee = false;
        public frmMaintainUsers()
        {
            InitializeComponent();
        }

       
        private void lblPassword_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
           if (rBtnAdmin.Checked==true)
            {
                lblID.Text = "Enter Admin ID:";
                lblName.Text = "Enter Admin Name:";
                lblSurname.Text = "Enter Admin Surname:";
                lblPassword.Text = "Enter Admin Password";
                this.Height = 364;
                employee = false;
                admin = true;
            }
           else if (rBtnEmployee.Checked==true)
            {
                lblID.Text = "Enter Employee ID:";
                lblName.Text = "Enter Employee Name:";
                lblSurname.Text = "Enter Employee Surname:";
                lblPassword.Text = "Enter Employee Rank";
                this.Height = 364;
                employee = true;
                admin = false;
            }
           else
            {
                MessageBox.Show("Select a user");
            }
           
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (rBtnAdmin.Checked == true)
            {
                lblID.Text = "Enter Admin ID:";
                lblName.Text = "Enter Admin Name:";
                lblSurname.Text = "Enter Admin Surname:";
                lblPassword.Text = "Enter Admin Password";
                this.Height = 364;
                employee = false;
                admin = true;
            }
            else if (rBtnEmployee.Checked == true)
            {
                lblID.Text = "Enter Employee ID:";
                lblName.Text = "Enter Employee Name:";
                lblSurname.Text = "Enter Employee Surname:";
                lblPassword.Text = "Enter Employee Rank";
                this.Height = 364;
                employee = true;
                admin = false;
            }
            else
            {
                MessageBox.Show("Select a user");
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.Height = 143;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //variable declaration//
            SqlDataAdapter adap = new SqlDataAdapter();
            SqlCommand command;
            String sql;
            //try catch statement//
            //add users//
            try
            {
                if (admin == true)
                {
                    con.Open();
                    sql = $"INSERT INTO tblAdmins(adminID,adminName,adminSurname,adminPassword) VALUES('{txtID.Text}', '{txtName.Text}', '{txtSurname.Text}', '{txtPassword.Text}') ";
                    command = new SqlCommand(sql, con);
                    adap.InsertCommand = command;
                    adap.InsertCommand.ExecuteNonQuery();
                    con.Close();
                    //display: User successfully added//
                }
                else if (employee == true)
                {
                    con.Open();
                    sql = $"INSERT INTO tblEmployees(employeeID,employeName,employeSurname,employePassword,employeRank) VALUES('{txtID.Text}', '{txtName.Text}', '{txtSurname.Text}', '{txtPassword.Text}', '{txtRank.Text}') ";
                    adap = new SqlDataAdapter();
                    command = new SqlCommand(sql, con);
                    adap.InsertCommand = command;
                    adap.InsertCommand.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Users could not be added to the system.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rBtnAdmin.Checked == true)
            {
                lblID.Text = "Enter Admin ID:";
                lblName.Text = "Enter Admin Name:";
                lblSurname.Text = "Enter Admin Surname:";
                lblPassword.Text = "Enter Admin Password";
                lblRank.Visible = false;
                txtRank.Visible = false;
                this.Height = 364;
                employee = false;
                admin = true;
            }
            else if (rBtnEmployee.Checked == true)
            {
                lblID.Text = "Enter Employee ID:";
                lblName.Text = "Enter Employee Name:";
                lblSurname.Text = "Enter Employee Surname:";
                lblPassword.Text = "Enter Employee Rank";
                this.Height = 364;
                employee = true;
                admin = false;
            }
            else
            {
                MessageBox.Show("Select a user");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
