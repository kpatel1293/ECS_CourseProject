namespace ECS
{
    partial class ReportProblem
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
            this.problemTxt = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.EmpIDTxt = new System.Windows.Forms.Label();
            this.NmTxt = new System.Windows.Forms.Label();
            this.DescripTxt = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.desTxtBox = new System.Windows.Forms.TextBox();
            this.nmTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // problemTxt
            // 
            this.problemTxt.AutoSize = true;
            this.problemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTxt.Location = new System.Drawing.Point(35, 68);
            this.problemTxt.Name = "problemTxt";
            this.problemTxt.Size = new System.Drawing.Size(401, 55);
            this.problemTxt.TabIndex = 0;
            this.problemTxt.Text = "Report a Problem";
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(73, 372);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(157, 47);
            this.DoneBtn.TabIndex = 1;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // EmpIDTxt
            // 
            this.EmpIDTxt.AutoSize = true;
            this.EmpIDTxt.Location = new System.Drawing.Point(68, 174);
            this.EmpIDTxt.Name = "EmpIDTxt";
            this.EmpIDTxt.Size = new System.Drawing.Size(133, 25);
            this.EmpIDTxt.TabIndex = 2;
            this.EmpIDTxt.Text = "Employee ID";
            // 
            // NmTxt
            // 
            this.NmTxt.AutoSize = true;
            this.NmTxt.Location = new System.Drawing.Point(68, 226);
            this.NmTxt.Name = "NmTxt";
            this.NmTxt.Size = new System.Drawing.Size(153, 25);
            this.NmTxt.TabIndex = 3;
            this.NmTxt.Text = "Problem Name";
            // 
            // DescripTxt
            // 
            this.DescripTxt.AutoSize = true;
            this.DescripTxt.Location = new System.Drawing.Point(68, 278);
            this.DescripTxt.Name = "DescripTxt";
            this.DescripTxt.Size = new System.Drawing.Size(120, 25);
            this.DescripTxt.TabIndex = 4;
            this.DescripTxt.Text = "Description";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(336, 171);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(423, 31);
            this.idTxtBox.TabIndex = 5;
            // 
            // desTxtBox
            // 
            this.desTxtBox.Location = new System.Drawing.Point(336, 275);
            this.desTxtBox.Multiline = true;
            this.desTxtBox.Name = "desTxtBox";
            this.desTxtBox.Size = new System.Drawing.Size(423, 104);
            this.desTxtBox.TabIndex = 6;
            // 
            // nmTxtBox
            // 
            this.nmTxtBox.Location = new System.Drawing.Point(336, 223);
            this.nmTxtBox.Name = "nmTxtBox";
            this.nmTxtBox.Size = new System.Drawing.Size(423, 31);
            this.nmTxtBox.TabIndex = 7;
            // 
            // ReportProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmTxtBox);
            this.Controls.Add(this.desTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.DescripTxt);
            this.Controls.Add(this.NmTxt);
            this.Controls.Add(this.EmpIDTxt);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.problemTxt);
            this.Name = "ReportProblem";
            this.Text = "ReportProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemTxt;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label EmpIDTxt;
        private System.Windows.Forms.Label NmTxt;
        private System.Windows.Forms.Label DescripTxt;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox desTxtBox;
        private System.Windows.Forms.TextBox nmTxtBox;
    }
}