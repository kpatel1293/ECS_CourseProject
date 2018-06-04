namespace ECS
{
    partial class TrackEquip
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
            this.stTxt = new System.Windows.Forms.Label();
            this.equipIDTxtBox = new System.Windows.Forms.TextBox();
            this.equipIDTxt = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.TrackEquipTxt = new System.Windows.Forms.Label();
            this.msgTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stTxt
            // 
            this.stTxt.AutoSize = true;
            this.stTxt.Location = new System.Drawing.Point(131, 255);
            this.stTxt.Name = "stTxt";
            this.stTxt.Size = new System.Drawing.Size(73, 25);
            this.stTxt.TabIndex = 11;
            this.stTxt.Text = "Status";
            // 
            // equipIDTxtBox
            // 
            this.equipIDTxtBox.Location = new System.Drawing.Point(396, 165);
            this.equipIDTxtBox.Name = "equipIDTxtBox";
            this.equipIDTxtBox.Size = new System.Drawing.Size(304, 31);
            this.equipIDTxtBox.TabIndex = 13;
            this.equipIDTxtBox.Text = "Enter Equipment ID...";
            // 
            // equipIDTxt
            // 
            this.equipIDTxt.AutoSize = true;
            this.equipIDTxt.Location = new System.Drawing.Point(131, 167);
            this.equipIDTxt.Name = "equipIDTxt";
            this.equipIDTxt.Size = new System.Drawing.Size(140, 25);
            this.equipIDTxt.TabIndex = 12;
            this.equipIDTxt.Text = "Equipment ID";
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(447, 361);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(149, 49);
            this.doneBtn.TabIndex = 10;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(207, 361);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 49);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TrackEquipTxt
            // 
            this.TrackEquipTxt.AutoSize = true;
            this.TrackEquipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackEquipTxt.Location = new System.Drawing.Point(29, 53);
            this.TrackEquipTxt.Name = "TrackEquipTxt";
            this.TrackEquipTxt.Size = new System.Drawing.Size(387, 55);
            this.TrackEquipTxt.TabIndex = 8;
            this.TrackEquipTxt.Text = "Track Equipment";
            // 
            // msgTxt
            // 
            this.msgTxt.AutoSize = true;
            this.msgTxt.Location = new System.Drawing.Point(391, 255);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(343, 25);
            this.msgTxt.TabIndex = 14;
            this.msgTxt.Text = "Current Status for the Equipment...";
            // 
            // TrackEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.stTxt);
            this.Controls.Add(this.equipIDTxtBox);
            this.Controls.Add(this.equipIDTxt);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.TrackEquipTxt);
            this.Name = "TrackEquip";
            this.Text = "TrackEquip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stTxt;
        private System.Windows.Forms.TextBox equipIDTxtBox;
        private System.Windows.Forms.Label equipIDTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label TrackEquipTxt;
        private System.Windows.Forms.Label msgTxt;
    }
}