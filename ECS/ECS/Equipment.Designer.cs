namespace ECS
{
    partial class Equipment
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
            this.equipTxt = new System.Windows.Forms.Label();
            this.chkOutBtn = new System.Windows.Forms.Button();
            this.chkInBtn = new System.Windows.Forms.Button();
            this.depotBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipCheckoutSystemDataSet = new ECS.EquipCheckoutSystemDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new ECS.EquipCheckoutSystemDataSetTableAdapters.EquipmentTableAdapter();
            this.equipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillClassReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipCheckoutSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipTxt
            // 
            this.equipTxt.AutoSize = true;
            this.equipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipTxt.Location = new System.Drawing.Point(39, 74);
            this.equipTxt.Name = "equipTxt";
            this.equipTxt.Size = new System.Drawing.Size(254, 55);
            this.equipTxt.TabIndex = 0;
            this.equipTxt.Text = "Equipment";
            // 
            // chkOutBtn
            // 
            this.chkOutBtn.Location = new System.Drawing.Point(407, 74);
            this.chkOutBtn.Name = "chkOutBtn";
            this.chkOutBtn.Size = new System.Drawing.Size(149, 49);
            this.chkOutBtn.TabIndex = 1;
            this.chkOutBtn.Text = "Check Out";
            this.chkOutBtn.UseVisualStyleBackColor = true;
            this.chkOutBtn.Click += new System.EventHandler(this.chkOutBtn_Click);
            // 
            // chkInBtn
            // 
            this.chkInBtn.Location = new System.Drawing.Point(609, 74);
            this.chkInBtn.Name = "chkInBtn";
            this.chkInBtn.Size = new System.Drawing.Size(149, 49);
            this.chkInBtn.TabIndex = 1;
            this.chkInBtn.Text = "Check In";
            this.chkInBtn.UseVisualStyleBackColor = true;
            // 
            // depotBtn
            // 
            this.depotBtn.Location = new System.Drawing.Point(603, 372);
            this.depotBtn.Name = "depotBtn";
            this.depotBtn.Size = new System.Drawing.Size(155, 51);
            this.depotBtn.TabIndex = 2;
            this.depotBtn.Text = "Depot";
            this.depotBtn.UseVisualStyleBackColor = true;
            this.depotBtn.Click += new System.EventHandler(this.depotBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.skillClassReqDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(709, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // equipCheckoutSystemDataSet
            // 
            this.equipCheckoutSystemDataSet.DataSetName = "EquipCheckoutSystemDataSet";
            this.equipCheckoutSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.equipCheckoutSystemDataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // equipIDDataGridViewTextBoxColumn
            // 
            this.equipIDDataGridViewTextBoxColumn.DataPropertyName = "EquipID";
            this.equipIDDataGridViewTextBoxColumn.HeaderText = "EquipID";
            this.equipIDDataGridViewTextBoxColumn.Name = "equipIDDataGridViewTextBoxColumn";
            this.equipIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skillClassReqDataGridViewTextBoxColumn
            // 
            this.skillClassReqDataGridViewTextBoxColumn.DataPropertyName = "SkillClassReq";
            this.skillClassReqDataGridViewTextBoxColumn.HeaderText = "SkillClassReq";
            this.skillClassReqDataGridViewTextBoxColumn.Name = "skillClassReqDataGridViewTextBoxColumn";
            this.skillClassReqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.depotBtn);
            this.Controls.Add(this.chkInBtn);
            this.Controls.Add(this.chkOutBtn);
            this.Controls.Add(this.equipTxt);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipCheckoutSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equipTxt;
        private System.Windows.Forms.Button chkOutBtn;
        private System.Windows.Forms.Button chkInBtn;
        private System.Windows.Forms.Button depotBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EquipCheckoutSystemDataSet equipCheckoutSystemDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private EquipCheckoutSystemDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillClassReqDataGridViewTextBoxColumn;
    }
}