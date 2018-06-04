namespace ECS
{
    partial class Manager
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
            this.mngTxt = new System.Windows.Forms.Label();
            this.empTxt = new System.Windows.Forms.Label();
            this.IDtxtBox = new System.Windows.Forms.TextBox();
            this.probBtn = new System.Windows.Forms.Button();
            this.delMsgTxt = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mngTxt
            // 
            this.mngTxt.AutoSize = true;
            this.mngTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngTxt.Location = new System.Drawing.Point(27, 45);
            this.mngTxt.Name = "mngTxt";
            this.mngTxt.Size = new System.Drawing.Size(353, 55);
            this.mngTxt.TabIndex = 4;
            this.mngTxt.Text = "Manager Portal";
            // 
            // empTxt
            // 
            this.empTxt.AutoSize = true;
            this.empTxt.Location = new System.Drawing.Point(32, 153);
            this.empTxt.Name = "empTxt";
            this.empTxt.Size = new System.Drawing.Size(133, 25);
            this.empTxt.TabIndex = 6;
            this.empTxt.Text = "Employee ID";
            // 
            // IDtxtBox
            // 
            this.IDtxtBox.Location = new System.Drawing.Point(243, 153);
            this.IDtxtBox.Name = "IDtxtBox";
            this.IDtxtBox.Size = new System.Drawing.Size(162, 31);
            this.IDtxtBox.TabIndex = 7;
            // 
            // probBtn
            // 
            this.probBtn.Location = new System.Drawing.Point(207, 338);
            this.probBtn.Name = "probBtn";
            this.probBtn.Size = new System.Drawing.Size(361, 45);
            this.probBtn.TabIndex = 8;
            this.probBtn.Text = "Generate Problem";
            this.probBtn.UseVisualStyleBackColor = true;
            this.probBtn.Click += new System.EventHandler(this.probBtn_Click);
            // 
            // delMsgTxt
            // 
            this.delMsgTxt.AutoSize = true;
            this.delMsgTxt.Location = new System.Drawing.Point(37, 214);
            this.delMsgTxt.Name = "delMsgTxt";
            this.delMsgTxt.Size = new System.Drawing.Size(0, 25);
            this.delMsgTxt.TabIndex = 9;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(207, 262);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(361, 48);
            this.addEmpBtn.TabIndex = 11;
            this.addEmpBtn.Text = "Create New Employee Profile";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(505, 146);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(267, 45);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "Terminate Employee";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.delMsgTxt);
            this.Controls.Add(this.probBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.IDtxtBox);
            this.Controls.Add(this.empTxt);
            this.Controls.Add(this.mngTxt);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mngTxt;
        private System.Windows.Forms.Label empTxt;
        private System.Windows.Forms.TextBox IDtxtBox;
        private System.Windows.Forms.Button probBtn;
        private System.Windows.Forms.Label delMsgTxt;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button delBtn;
    }
}