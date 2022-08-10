
namespace CMPG223_Salon_Projek
{
    partial class frmEmployee
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
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnMaintainTreatments = new System.Windows.Forms.Button();
            this.btnMaintainProducts = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(236, 86);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(122, 23);
            this.btnAppointment.TabIndex = 10;
            this.btnAppointment.Text = "Schedule Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnMaintainTreatments
            // 
            this.btnMaintainTreatments.Location = new System.Drawing.Point(430, 22);
            this.btnMaintainTreatments.Name = "btnMaintainTreatments";
            this.btnMaintainTreatments.Size = new System.Drawing.Size(122, 23);
            this.btnMaintainTreatments.TabIndex = 9;
            this.btnMaintainTreatments.Text = "Maintain Treatments";
            this.btnMaintainTreatments.UseVisualStyleBackColor = true;
            this.btnMaintainTreatments.Click += new System.EventHandler(this.btnMaintainTreatments_Click);
            // 
            // btnMaintainProducts
            // 
            this.btnMaintainProducts.Location = new System.Drawing.Point(236, 22);
            this.btnMaintainProducts.Name = "btnMaintainProducts";
            this.btnMaintainProducts.Size = new System.Drawing.Size(122, 23);
            this.btnMaintainProducts.TabIndex = 8;
            this.btnMaintainProducts.Text = "Maintain Products";
            this.btnMaintainProducts.UseVisualStyleBackColor = true;
            this.btnMaintainProducts.Click += new System.EventHandler(this.btnMaintainProducts_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(36, 22);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(122, 23);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "Maintain Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(36, 86);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(122, 23);
            this.btnSell.TabIndex = 12;
            this.btnSell.Text = "Sell Product/-s";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(516, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnMaintainProducts);
            this.panel1.Controls.Add(this.btnAppointment);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.btnMaintainTreatments);
            this.panel1.Location = new System.Drawing.Point(42, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 138);
            this.panel1.TabIndex = 14;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(199, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(278, 25);
            this.lblSelect.TabIndex = 15;
            this.lblSelect.Text = "Select an action to continue";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(680, 304);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmEmployee";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnMaintainTreatments;
        private System.Windows.Forms.Button btnMaintainProducts;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelect;
    }
}