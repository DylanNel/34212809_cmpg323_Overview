
namespace CMPG223_Salon_Projek
{
    partial class frmMaintainEmployees
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
            this.DGView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDBDataSet6 = new CMPG223_Salon_Projek.SalonDBDataSet6();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.salonDBDataSet5 = new CMPG223_Salon_Projek.SalonDBDataSet5();
            this.tblClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClientTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet5TableAdapters.tblClientTableAdapter();
            this.tblEmployeesTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet6TableAdapters.tblEmployeesTableAdapter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeeRankDataGridViewTextBoxColumn});
            this.DGView.DataSource = this.tblEmployeesBindingSource;
            this.DGView.Location = new System.Drawing.Point(76, 126);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(637, 218);
            this.DGView.TabIndex = 7;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_CellContentClick);
            this.DGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGView_RowHeaderMouseClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "employeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "employeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "employeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "employeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            // 
            // employeeRankDataGridViewTextBoxColumn
            // 
            this.employeeRankDataGridViewTextBoxColumn.DataPropertyName = "employeeRank";
            this.employeeRankDataGridViewTextBoxColumn.HeaderText = "employeeRank";
            this.employeeRankDataGridViewTextBoxColumn.Name = "employeeRankDataGridViewTextBoxColumn";
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.salonDBDataSet6;
            // 
            // salonDBDataSet6
            // 
            this.salonDBDataSet6.DataSetName = "SalonDBDataSet6";
            this.salonDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(258, 59);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(261, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(76, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // salonDBDataSet5
            // 
            this.salonDBDataSet5.DataSetName = "SalonDBDataSet5";
            this.salonDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClientBindingSource
            // 
            this.tblClientBindingSource.DataMember = "tblClient";
            this.tblClientBindingSource.DataSource = this.salonDBDataSet5;
            // 
            // tblClientTableAdapter
            // 
            this.tblClientTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(424, 379);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmMaintainEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DGView);
            this.Name = "frmMaintainEmployees";
            this.Text = "Maintain Employees";
            this.Load += new System.EventHandler(this.frmMaintainEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
        private SalonDBDataSet5 salonDBDataSet5;
        private System.Windows.Forms.BindingSource tblClientBindingSource;
        private SalonDBDataSet5TableAdapters.tblClientTableAdapter tblClientTableAdapter;
        private SalonDBDataSet6 salonDBDataSet6;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private SalonDBDataSet6TableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeRankDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}