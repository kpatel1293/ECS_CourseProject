namespace ECS
{
    partial class ModifyEquip
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
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.Label();
            this.equipTxtBox = new System.Windows.Forms.TextBox();
            this.equipNmTxt = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modifyEquipTxt = new System.Windows.Forms.Label();
            this.EquipIdTxt = new System.Windows.Forms.Label();
            this.EquipIDTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(408, 273);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(304, 31);
            this.priceTxtBox.TabIndex = 14;
            this.priceTxtBox.Text = "Enter Price...";
            // 
            // PriceTxt
            // 
            this.PriceTxt.AutoSize = true;
            this.PriceTxt.Location = new System.Drawing.Point(143, 273);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(61, 25);
            this.PriceTxt.TabIndex = 11;
            this.PriceTxt.Text = "Price";
            // 
            // equipTxtBox
            // 
            this.equipTxtBox.Location = new System.Drawing.Point(408, 209);
            this.equipTxtBox.Name = "equipTxtBox";
            this.equipTxtBox.Size = new System.Drawing.Size(304, 31);
            this.equipTxtBox.TabIndex = 13;
            this.equipTxtBox.Text = "Enter Equipment Name...";
            // 
            // equipNmTxt
            // 
            this.equipNmTxt.AutoSize = true;
            this.equipNmTxt.Location = new System.Drawing.Point(143, 211);
            this.equipNmTxt.Name = "equipNmTxt";
            this.equipNmTxt.Size = new System.Drawing.Size(176, 25);
            this.equipNmTxt.TabIndex = 12;
            this.equipNmTxt.Text = "Equipment Name";
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(465, 365);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(149, 49);
            this.doneBtn.TabIndex = 10;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(225, 365);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 49);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // modifyEquipTxt
            // 
            this.modifyEquipTxt.AutoSize = true;
            this.modifyEquipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEquipTxt.Location = new System.Drawing.Point(47, 57);
            this.modifyEquipTxt.Name = "modifyEquipTxt";
            this.modifyEquipTxt.Size = new System.Drawing.Size(408, 55);
            this.modifyEquipTxt.TabIndex = 8;
            this.modifyEquipTxt.Text = "Modify Equipment";
            // 
            // EquipIdTxt
            // 
            this.EquipIdTxt.AutoSize = true;
            this.EquipIdTxt.Location = new System.Drawing.Point(143, 153);
            this.EquipIdTxt.Name = "EquipIdTxt";
            this.EquipIdTxt.Size = new System.Drawing.Size(140, 25);
            this.EquipIdTxt.TabIndex = 12;
            this.EquipIdTxt.Text = "Equipment ID";
            // 
            // EquipIDTxtBox
            // 
            this.EquipIDTxtBox.Location = new System.Drawing.Point(408, 151);
            this.EquipIDTxtBox.Name = "EquipIDTxtBox";
            this.EquipIDTxtBox.Size = new System.Drawing.Size(304, 31);
            this.EquipIDTxtBox.TabIndex = 13;
            this.EquipIDTxtBox.Text = "Enter Equipment ID...";
            // 
            // ModifyEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.EquipIDTxtBox);
            this.Controls.Add(this.EquipIdTxt);
            this.Controls.Add(this.equipTxtBox);
            this.Controls.Add(this.equipNmTxt);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.modifyEquipTxt);
            this.Name = "ModifyEquip";
            this.Text = "ModifyEquip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label PriceTxt;
        private System.Windows.Forms.TextBox equipTxtBox;
        private System.Windows.Forms.Label equipNmTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label modifyEquipTxt;
        private System.Windows.Forms.Label EquipIdTxt;
        private System.Windows.Forms.TextBox EquipIDTxtBox;
    }
}