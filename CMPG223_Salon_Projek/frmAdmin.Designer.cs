
namespace CMPG223_Salon_Projek
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnMaintainProducts = new System.Windows.Forms.Button();
            this.btnMaintainTreatments = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(16, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(122, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Request Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(16, 22);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(122, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Maintain Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnMaintainProducts
            // 
            this.btnMaintainProducts.Location = new System.Drawing.Point(227, 22);
            this.btnMaintainProducts.Name = "btnMaintainProducts";
            this.btnMaintainProducts.Size = new System.Drawing.Size(122, 23);
            this.btnMaintainProducts.TabIndex = 3;
            this.btnMaintainProducts.Text = "Maintain Products";
            this.btnMaintainProducts.UseVisualStyleBackColor = true;
            this.btnMaintainProducts.Click += new System.EventHandler(this.btnMaintainProducts_Click);
            // 
            // btnMaintainTreatments
            // 
            this.btnMaintainTreatments.Location = new System.Drawing.Point(412, 22);
            this.btnMaintainTreatments.Name = "btnMaintainTreatments";
            this.btnMaintainTreatments.Size = new System.Drawing.Size(122, 23);
            this.btnMaintainTreatments.TabIndex = 4;
            this.btnMaintainTreatments.Text = "Maintain Treatments";
            this.btnMaintainTreatments.UseVisualStyleBackColor = true;
            this.btnMaintainTreatments.Click += new System.EventHandler(this.btnMaintainTreatments_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(16, 70);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(122, 23);
            this.btnAppointment.TabIndex = 5;
            this.btnAppointment.Text = "Schedule Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(227, 70);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(122, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell Product/-s";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(471, 265);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(256, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(122, 23);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.pnlAdmin.Controls.Add(this.btnReport);
            this.pnlAdmin.Controls.Add(this.btnAddUser);
            this.pnlAdmin.Location = new System.Drawing.Point(122, 52);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(404, 51);
            this.pnlAdmin.TabIndex = 12;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.SlateGray;
            this.pnlGeneral.Controls.Add(this.btnClient);
            this.pnlGeneral.Controls.Add(this.btnMaintainProducts);
            this.pnlGeneral.Controls.Add(this.btnMaintainTreatments);
            this.pnlGeneral.Controls.Add(this.btnSell);
            this.pnlGeneral.Controls.Add(this.btnAppointment);
            this.pnlGeneral.Location = new System.Drawing.Point(38, 127);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(555, 121);
            this.pnlGeneral.TabIndex = 13;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(198, 13);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(266, 25);
            this.lblSelect.TabIndex = 14;
            this.lblSelect.Text = "Select an action to cotinue";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAdmin";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnMaintainProducts;
        private System.Windows.Forms.Button btnMaintainTreatments;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label lblSelect;
    }
}