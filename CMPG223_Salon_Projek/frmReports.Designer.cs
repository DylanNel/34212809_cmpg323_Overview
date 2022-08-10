
namespace CMPG223_Salon_Projek
{
    partial class frmReports
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
            this.chkBoxStartDate = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.chkBoxEndDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.reportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officialDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDBDataSet10 = new CMPG223_Salon_Projek.SalonDBDataSet10();
            this.salonDBDataSet = new CMPG223_Salon_Projek.SalonDBDataSet();
            this.salonDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReportsTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet10TableAdapters.tblReportsTableAdapter();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBoxStartDate
            // 
            this.chkBoxStartDate.AutoSize = true;
            this.chkBoxStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxStartDate.Location = new System.Drawing.Point(78, 39);
            this.chkBoxStartDate.Name = "chkBoxStartDate";
            this.chkBoxStartDate.Size = new System.Drawing.Size(150, 20);
            this.chkBoxStartDate.TabIndex = 0;
            this.chkBoxStartDate.Text = "Include Start Date";
            this.chkBoxStartDate.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(78, 131);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(533, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(172, 81);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // chkBoxEndDate
            // 
            this.chkBoxEndDate.AutoSize = true;
            this.chkBoxEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxEndDate.Location = new System.Drawing.Point(425, 39);
            this.chkBoxEndDate.Name = "chkBoxEndDate";
            this.chkBoxEndDate.Size = new System.Drawing.Size(145, 20);
            this.chkBoxEndDate.TabIndex = 1;
            this.chkBoxEndDate.Text = "Include End Date";
            this.chkBoxEndDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(519, 81);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(75, 87);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 13);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Select Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(422, 87);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Select End Date:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(485, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.treatmentIDDataGridViewTextBoxColumn,
            this.reportAmountDataGridViewTextBoxColumn,
            this.serviceRatingDataGridViewTextBoxColumn,
            this.officialDateDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.DGView.DataSource = this.tblReportsBindingSource;
            this.DGView.Location = new System.Drawing.Point(78, 177);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(870, 216);
            this.DGView.TabIndex = 13;
            this.DGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGView_RowHeaderMouseClick);
            // 
            // reportIDDataGridViewTextBoxColumn
            // 
            this.reportIDDataGridViewTextBoxColumn.DataPropertyName = "reportID";
            this.reportIDDataGridViewTextBoxColumn.HeaderText = "reportID";
            this.reportIDDataGridViewTextBoxColumn.Name = "reportIDDataGridViewTextBoxColumn";
            this.reportIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 79;
            // 
            // treatmentIDDataGridViewTextBoxColumn
            // 
            this.treatmentIDDataGridViewTextBoxColumn.DataPropertyName = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.HeaderText = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.Name = "treatmentIDDataGridViewTextBoxColumn";
            this.treatmentIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // reportAmountDataGridViewTextBoxColumn
            // 
            this.reportAmountDataGridViewTextBoxColumn.DataPropertyName = "reportAmount";
            this.reportAmountDataGridViewTextBoxColumn.HeaderText = "reportAmount";
            this.reportAmountDataGridViewTextBoxColumn.Name = "reportAmountDataGridViewTextBoxColumn";
            this.reportAmountDataGridViewTextBoxColumn.Width = 95;
            // 
            // serviceRatingDataGridViewTextBoxColumn
            // 
            this.serviceRatingDataGridViewTextBoxColumn.DataPropertyName = "serviceRating";
            this.serviceRatingDataGridViewTextBoxColumn.HeaderText = "serviceRating";
            this.serviceRatingDataGridViewTextBoxColumn.Name = "serviceRatingDataGridViewTextBoxColumn";
            this.serviceRatingDataGridViewTextBoxColumn.Width = 97;
            // 
            // officialDateDataGridViewTextBoxColumn
            // 
            this.officialDateDataGridViewTextBoxColumn.DataPropertyName = "officialDate";
            this.officialDateDataGridViewTextBoxColumn.HeaderText = "officialDate";
            this.officialDateDataGridViewTextBoxColumn.Name = "officialDateDataGridViewTextBoxColumn";
            this.officialDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 88;
            // 
            // tblReportsBindingSource
            // 
            this.tblReportsBindingSource.DataMember = "tblReports";
            this.tblReportsBindingSource.DataSource = this.salonDBDataSet10;
            // 
            // salonDBDataSet10
            // 
            this.salonDBDataSet10.DataSetName = "SalonDBDataSet10";
            this.salonDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblReportsTableAdapter
            // 
            this.tblReportsTableAdapter.ClearBeforeFill = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(785, 91);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(788, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.chkBoxEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.chkBoxStartDate);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkBoxStartDate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.CheckBox chkBoxEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.BindingSource salonDBDataSetBindingSource;
        private SalonDBDataSet salonDBDataSet;
        private SalonDBDataSet10 salonDBDataSet10;
        private System.Windows.Forms.BindingSource tblReportsBindingSource;
        private SalonDBDataSet10TableAdapters.tblReportsTableAdapter tblReportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officialDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}