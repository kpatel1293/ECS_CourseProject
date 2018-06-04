namespace ECS
{
    partial class Form1
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
            this.empBtn = new System.Windows.Forms.Button();
            this.equipBtn = new System.Windows.Forms.Button();
            this.welTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empBtn
            // 
            this.empBtn.Location = new System.Drawing.Point(157, 206);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(183, 53);
            this.empBtn.TabIndex = 0;
            this.empBtn.Text = "Employee";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // equipBtn
            // 
            this.equipBtn.Location = new System.Drawing.Point(479, 206);
            this.equipBtn.Name = "equipBtn";
            this.equipBtn.Size = new System.Drawing.Size(183, 53);
            this.equipBtn.TabIndex = 0;
            this.equipBtn.Text = "Equipment";
            this.equipBtn.UseVisualStyleBackColor = true;
            this.equipBtn.Click += new System.EventHandler(this.equipBtn_Click);
            // 
            // welTxt
            // 
            this.welTxt.AutoSize = true;
            this.welTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welTxt.Location = new System.Drawing.Point(31, 62);
            this.welTxt.Name = "welTxt";
            this.welTxt.Size = new System.Drawing.Size(237, 55);
            this.welTxt.TabIndex = 1;
            this.welTxt.Text = "Welcome!";
            this.welTxt.Click += new System.EventHandler(this.welTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welTxt);
            this.Controls.Add(this.equipBtn);
            this.Controls.Add(this.empBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.Button equipBtn;
        private System.Windows.Forms.Label welTxt;
    }
}

