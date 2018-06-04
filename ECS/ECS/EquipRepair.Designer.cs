namespace ECS
{
    partial class EquipRepair
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
            this.probTxtBox = new System.Windows.Forms.TextBox();
            this.probTxt = new System.Windows.Forms.Label();
            this.equipIDTxtBox = new System.Windows.Forms.TextBox();
            this.equipIDTxt = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.repairEquipTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // probTxtBox
            // 
            this.probTxtBox.Location = new System.Drawing.Point(412, 237);
            this.probTxtBox.Multiline = true;
            this.probTxtBox.Name = "probTxtBox";
            this.probTxtBox.Size = new System.Drawing.Size(304, 83);
            this.probTxtBox.TabIndex = 14;
            // 
            // probTxt
            // 
            this.probTxt.AutoSize = true;
            this.probTxt.Location = new System.Drawing.Point(147, 237);
            this.probTxt.Name = "probTxt";
            this.probTxt.Size = new System.Drawing.Size(91, 25);
            this.probTxt.TabIndex = 11;
            this.probTxt.Text = "Problem";
            // 
            // equipIDTxtBox
            // 
            this.equipIDTxtBox.Location = new System.Drawing.Point(412, 167);
            this.equipIDTxtBox.Name = "equipIDTxtBox";
            this.equipIDTxtBox.Size = new System.Drawing.Size(304, 31);
            this.equipIDTxtBox.TabIndex = 13;
            this.equipIDTxtBox.Text = "Enter Equipment ID...";
            // 
            // equipIDTxt
            // 
            this.equipIDTxt.AutoSize = true;
            this.equipIDTxt.Location = new System.Drawing.Point(147, 169);
            this.equipIDTxt.Name = "equipIDTxt";
            this.equipIDTxt.Size = new System.Drawing.Size(140, 25);
            this.equipIDTxt.TabIndex = 12;
            this.equipIDTxt.Text = "Equipment ID";
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(463, 363);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(149, 49);
            this.doneBtn.TabIndex = 10;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(223, 363);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 49);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // repairEquipTxt
            // 
            this.repairEquipTxt.AutoSize = true;
            this.repairEquipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairEquipTxt.Location = new System.Drawing.Point(45, 55);
            this.repairEquipTxt.Name = "repairEquipTxt";
            this.repairEquipTxt.Size = new System.Drawing.Size(409, 55);
            this.repairEquipTxt.TabIndex = 8;
            this.repairEquipTxt.Text = "Repair Equipment";
            // 
            // EquipRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.probTxtBox);
            this.Controls.Add(this.probTxt);
            this.Controls.Add(this.equipIDTxtBox);
            this.Controls.Add(this.equipIDTxt);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.repairEquipTxt);
            this.Name = "EquipRepair";
            this.Text = "EquipRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox probTxtBox;
        private System.Windows.Forms.Label probTxt;
        private System.Windows.Forms.TextBox equipIDTxtBox;
        private System.Windows.Forms.Label equipIDTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label repairEquipTxt;
    }
}