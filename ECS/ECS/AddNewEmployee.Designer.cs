namespace ECS
{
    partial class AddNewEmployee
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
            this.DoneBtn = new System.Windows.Forms.Button();
            this.mangEmpR = new System.Windows.Forms.RadioButton();
            this.depotEmpR = new System.Windows.Forms.RadioButton();
            this.regEmpR = new System.Windows.Forms.RadioButton();
            this.skillTxt = new System.Windows.Forms.Label();
            this.LNmTxtBox = new System.Windows.Forms.TextBox();
            this.fNmTxtField = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.Label();
            this.fNmTxt = new System.Windows.Forms.Label();
            this.addTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(575, 360);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(149, 49);
            this.DoneBtn.TabIndex = 15;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // mangEmpR
            // 
            this.mangEmpR.AutoSize = true;
            this.mangEmpR.Location = new System.Drawing.Point(209, 320);
            this.mangEmpR.Name = "mangEmpR";
            this.mangEmpR.Size = new System.Drawing.Size(159, 29);
            this.mangEmpR.TabIndex = 12;
            this.mangEmpR.TabStop = true;
            this.mangEmpR.Text = "3 - Manager";
            this.mangEmpR.UseVisualStyleBackColor = true;
            // 
            // depotEmpR
            // 
            this.depotEmpR.AutoSize = true;
            this.depotEmpR.Location = new System.Drawing.Point(209, 270);
            this.depotEmpR.Name = "depotEmpR";
            this.depotEmpR.Size = new System.Drawing.Size(232, 29);
            this.depotEmpR.TabIndex = 13;
            this.depotEmpR.TabStop = true;
            this.depotEmpR.Text = "2 - Employee Depot";
            this.depotEmpR.UseVisualStyleBackColor = true;
            // 
            // regEmpR
            // 
            this.regEmpR.AutoSize = true;
            this.regEmpR.Location = new System.Drawing.Point(209, 220);
            this.regEmpR.Name = "regEmpR";
            this.regEmpR.Size = new System.Drawing.Size(250, 29);
            this.regEmpR.TabIndex = 14;
            this.regEmpR.TabStop = true;
            this.regEmpR.Text = "1 - Regular Employee";
            this.regEmpR.UseVisualStyleBackColor = true;
            // 
            // skillTxt
            // 
            this.skillTxt.AutoSize = true;
            this.skillTxt.Location = new System.Drawing.Point(46, 220);
            this.skillTxt.Name = "skillTxt";
            this.skillTxt.Size = new System.Drawing.Size(112, 25);
            this.skillTxt.TabIndex = 11;
            this.skillTxt.Text = "Skill Class";
            // 
            // LNmTxtBox
            // 
            this.LNmTxtBox.Location = new System.Drawing.Point(575, 153);
            this.LNmTxtBox.Name = "LNmTxtBox";
            this.LNmTxtBox.Size = new System.Drawing.Size(150, 31);
            this.LNmTxtBox.TabIndex = 9;
            // 
            // fNmTxtField
            // 
            this.fNmTxtField.Location = new System.Drawing.Point(209, 153);
            this.fNmTxtField.Name = "fNmTxtField";
            this.fNmTxtField.Size = new System.Drawing.Size(150, 31);
            this.fNmTxtField.TabIndex = 10;
            // 
            // lNameTxt
            // 
            this.lNameTxt.AutoSize = true;
            this.lNameTxt.Location = new System.Drawing.Point(407, 156);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(115, 25);
            this.lNameTxt.TabIndex = 7;
            this.lNameTxt.Text = "Last Name";
            // 
            // fNmTxt
            // 
            this.fNmTxt.AutoSize = true;
            this.fNmTxt.Location = new System.Drawing.Point(41, 156);
            this.fNmTxt.Name = "fNmTxt";
            this.fNmTxt.Size = new System.Drawing.Size(116, 25);
            this.fNmTxt.TabIndex = 8;
            this.fNmTxt.Text = "First Name";
            // 
            // addTxt
            // 
            this.addTxt.AutoSize = true;
            this.addTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTxt.Location = new System.Drawing.Point(31, 58);
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(447, 55);
            this.addTxt.TabIndex = 6;
            this.addTxt.Text = "Add New Employee";
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.mangEmpR);
            this.Controls.Add(this.depotEmpR);
            this.Controls.Add(this.regEmpR);
            this.Controls.Add(this.skillTxt);
            this.Controls.Add(this.LNmTxtBox);
            this.Controls.Add(this.fNmTxtField);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.fNmTxt);
            this.Controls.Add(this.addTxt);
            this.Name = "AddNewEmployee";
            this.Text = "AddNewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.RadioButton mangEmpR;
        private System.Windows.Forms.RadioButton depotEmpR;
        private System.Windows.Forms.RadioButton regEmpR;
        private System.Windows.Forms.Label skillTxt;
        private System.Windows.Forms.TextBox LNmTxtBox;
        private System.Windows.Forms.TextBox fNmTxtField;
        private System.Windows.Forms.Label lNameTxt;
        private System.Windows.Forms.Label fNmTxt;
        private System.Windows.Forms.Label addTxt;
    }
}