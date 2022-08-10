
namespace CMPG223_Salon_Projek
{
    partial class frmAppointment
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDBDataSet3 = new CMPG223_Salon_Projek.SalonDBDataSet3();
            this.salonDBDataSet = new CMPG223_Salon_Projek.SalonDBDataSet();
            this.salonDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDBDataSet2 = new CMPG223_Salon_Projek.SalonDBDataSet2();
            this.tblAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentsTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet2TableAdapters.tblAppointmentsTableAdapter();
            this.tblAppointmentTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet3TableAdapters.tblAppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(277, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(394, 301);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(137, 23);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule Appointment";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(52, 301);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Appointment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(228, 301);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Appointment";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(205, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(202, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.appointmentTimeDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn});
            this.DGView.DataSource = this.tblAppointmentBindingSource;
            this.DGView.Location = new System.Drawing.Point(40, 79);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(726, 150);
            this.DGView.TabIndex = 6;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGView_RowHeaderMouseClick);
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "appointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "appointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "appointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointmentTimeDataGridViewTextBoxColumn
            // 
            this.appointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "appointmentTime";
            this.appointmentTimeDataGridViewTextBoxColumn.HeaderText = "appointmentTime";
            this.appointmentTimeDataGridViewTextBoxColumn.Name = "appointmentTimeDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "clientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "clientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "clientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "clientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            // 
            // tblAppointmentBindingSource
            // 
            this.tblAppointmentBindingSource.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource.DataSource = this.salonDBDataSet3;
            // 
            // salonDBDataSet3
            // 
            this.salonDBDataSet3.DataSetName = "SalonDBDataSet3";
            this.salonDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonDBDataSet
            // 
            this.salonDBDataSet.DataSetName = "SalonDBDataSet";
            this.salonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonDBDataSetBindingSource
            // 
            this.salonDBDataSetBindingSource.DataSource = this.salonDBDataSet;
            this.salonDBDataSetBindingSource.Position = 0;
            // 
            // salonDBDataSet2
            // 
            this.salonDBDataSet2.DataSetName = "SalonDBDataSet2";
            this.salonDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentsBindingSource
            // 
            this.tblAppointmentsBindingSource.DataMember = "tblAppointments";
            this.tblAppointmentsBindingSource.DataSource = this.salonDBDataSet2;
            // 
            // tblAppointmentsTableAdapter
            // 
            this.tblAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tblAppointmentTableAdapter
            // 
            this.tblAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAppointment";
            this.Text = "Schedule Appointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.BindingSource salonDBDataSetBindingSource;
        private SalonDBDataSet salonDBDataSet;
        private SalonDBDataSet2 salonDBDataSet2;
        private System.Windows.Forms.BindingSource tblAppointmentsBindingSource;
        private SalonDBDataSet2TableAdapters.tblAppointmentsTableAdapter tblAppointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private SalonDBDataSet3 salonDBDataSet3;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource;
        private SalonDBDataSet3TableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter;
    }
}