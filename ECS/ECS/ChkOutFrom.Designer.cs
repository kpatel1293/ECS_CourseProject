namespace ECS
{
    partial class ChkOutFrom
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
            this.chkOutTxt = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.chkOutBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.Label();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkOutTxt
            // 
            this.chkOutTxt.AutoSize = true;
            this.chkOutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOutTxt.Location = new System.Drawing.Point(24, 62);
            this.chkOutTxt.Name = "chkOutTxt";
            this.chkOutTxt.Size = new System.Drawing.Size(251, 55);
            this.chkOutTxt.TabIndex = 2;
            this.chkOutTxt.Text = "Check Out";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(241, 358);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(154, 44);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // chkOutBtn
            // 
            this.chkOutBtn.Location = new System.Drawing.Point(447, 358);
            this.chkOutBtn.Name = "chkOutBtn";
            this.chkOutBtn.Size = new System.Drawing.Size(154, 44);
            this.chkOutBtn.TabIndex = 4;
            this.chkOutBtn.Text = "Check Out";
            this.chkOutBtn.UseVisualStyleBackColor = true;
            this.chkOutBtn.Click += new System.EventHandler(this.chkOutBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.AutoSize = true;
            this.IdTxt.Location = new System.Drawing.Point(205, 172);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(190, 25);
            this.IdTxt.TabIndex = 5;
            this.IdTxt.Text = "Enter Employee ID";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(479, 166);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(100, 31);
            this.IdTxtBox.TabIndex = 6;
            // 
            // ChkOutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.chkOutBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.chkOutTxt);
            this.Name = "ChkOutFrom";
            this.Text = "ChkOutFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chkOutTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button chkOutBtn;
        private System.Windows.Forms.Label IdTxt;
        private System.Windows.Forms.TextBox IdTxtBox;
    }
}