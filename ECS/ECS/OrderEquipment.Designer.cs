namespace ECS
{
    partial class OrderEquipment
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.ordrEquipTxt = new System.Windows.Forms.Label();
            this.equipNmTxt = new System.Windows.Forms.Label();
            this.equipTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(441, 358);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(149, 49);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(201, 358);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 49);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ordrEquipTxt
            // 
            this.ordrEquipTxt.AutoSize = true;
            this.ordrEquipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordrEquipTxt.Location = new System.Drawing.Point(23, 50);
            this.ordrEquipTxt.Name = "ordrEquipTxt";
            this.ordrEquipTxt.Size = new System.Drawing.Size(390, 55);
            this.ordrEquipTxt.TabIndex = 2;
            this.ordrEquipTxt.Text = "Order Equipment";
            this.ordrEquipTxt.Click += new System.EventHandler(this.ordrEquipTxt_Click);
            // 
            // equipNmTxt
            // 
            this.equipNmTxt.AutoSize = true;
            this.equipNmTxt.Location = new System.Drawing.Point(125, 164);
            this.equipNmTxt.Name = "equipNmTxt";
            this.equipNmTxt.Size = new System.Drawing.Size(176, 25);
            this.equipNmTxt.TabIndex = 5;
            this.equipNmTxt.Text = "Equipment Name";
            this.equipNmTxt.Click += new System.EventHandler(this.equipNmTxt_Click);
            // 
            // equipTxtBox
            // 
            this.equipTxtBox.Location = new System.Drawing.Point(390, 162);
            this.equipTxtBox.Name = "equipTxtBox";
            this.equipTxtBox.Size = new System.Drawing.Size(304, 31);
            this.equipTxtBox.TabIndex = 6;
            this.equipTxtBox.Text = "Enter Equipment Name...";
            this.equipTxtBox.TextChanged += new System.EventHandler(this.equipTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(390, 252);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(304, 31);
            this.priceTxtBox.TabIndex = 7;
            this.priceTxtBox.Text = "Enter Price...";
            this.priceTxtBox.TextChanged += new System.EventHandler(this.priceTxtBox_TextChanged);
            // 
            // OrderEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipTxtBox);
            this.Controls.Add(this.equipNmTxt);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.ordrEquipTxt);
            this.Name = "OrderEquipment";
            this.Text = "OrderEquipment";
            this.Load += new System.EventHandler(this.OrderEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label ordrEquipTxt;
        private System.Windows.Forms.Label equipNmTxt;
        private System.Windows.Forms.TextBox equipTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTxtBox;
    }
}