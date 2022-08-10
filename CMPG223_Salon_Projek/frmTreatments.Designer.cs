
namespace CMPG223_Salon_Projek
{
    partial class frmTreatments
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.treatmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTreatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDBDataSet8 = new CMPG223_Salon_Projek.SalonDBDataSet8();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblTreatmentTableAdapter = new CMPG223_Salon_Projek.SalonDBDataSet8TableAdapters.tblTreatmentTableAdapter();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(263, 58);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatmentIDDataGridViewTextBoxColumn,
            this.treatmentTypeDataGridViewTextBoxColumn,
            this.treatmentPriceDataGridViewTextBoxColumn});
            this.DGView.DataSource = this.tblTreatmentBindingSource;
            this.DGView.Location = new System.Drawing.Point(179, 147);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(362, 150);
            this.DGView.TabIndex = 11;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_CellContentClick);
            this.DGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGView_RowHeaderMouseClick);
            // 
            // treatmentIDDataGridViewTextBoxColumn
            // 
            this.treatmentIDDataGridViewTextBoxColumn.DataPropertyName = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.HeaderText = "treatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.Name = "treatmentIDDataGridViewTextBoxColumn";
            // 
            // treatmentTypeDataGridViewTextBoxColumn
            // 
            this.treatmentTypeDataGridViewTextBoxColumn.DataPropertyName = "treatmentType";
            this.treatmentTypeDataGridViewTextBoxColumn.HeaderText = "treatmentType";
            this.treatmentTypeDataGridViewTextBoxColumn.Name = "treatmentTypeDataGridViewTextBoxColumn";
            // 
            // treatmentPriceDataGridViewTextBoxColumn
            // 
            this.treatmentPriceDataGridViewTextBoxColumn.DataPropertyName = "treatmentPrice";
            this.treatmentPriceDataGridViewTextBoxColumn.HeaderText = "treatmentPrice";
            this.treatmentPriceDataGridViewTextBoxColumn.Name = "treatmentPriceDataGridViewTextBoxColumn";
            // 
            // tblTreatmentBindingSource
            // 
            this.tblTreatmentBindingSource.DataMember = "tblTreatment";
            this.tblTreatmentBindingSource.DataSource = this.salonDBDataSet8;
            // 
            // salonDBDataSet8
            // 
            this.salonDBDataSet8.DataSetName = "SalonDBDataSet8";
            this.salonDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(364, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tblTreatmentTableAdapter
            // 
            this.tblTreatmentTableAdapter.ClearBeforeFill = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(277, 370);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmTreatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.btnClose);
            this.Name = "frmTreatments";
            this.Text = "frmTreatments";
            this.Load += new System.EventHandler(this.frmTreatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDBDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.Button btnClose;
        private SalonDBDataSet8 salonDBDataSet8;
        private System.Windows.Forms.BindingSource tblTreatmentBindingSource;
        private SalonDBDataSet8TableAdapters.tblTreatmentTableAdapter tblTreatmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}