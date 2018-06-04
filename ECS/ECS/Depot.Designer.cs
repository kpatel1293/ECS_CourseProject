namespace ECS
{
    partial class Depot
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
            this.modEquipBtn = new System.Windows.Forms.Button();
            this.orderEquipBtn = new System.Windows.Forms.Button();
            this.depotTxt = new System.Windows.Forms.Label();
            this.repairBtn = new System.Windows.Forms.Button();
            this.trckEquipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modEquipBtn
            // 
            this.modEquipBtn.Location = new System.Drawing.Point(269, 225);
            this.modEquipBtn.Name = "modEquipBtn";
            this.modEquipBtn.Size = new System.Drawing.Size(261, 49);
            this.modEquipBtn.TabIndex = 4;
            this.modEquipBtn.Text = "Modify Equipment";
            this.modEquipBtn.UseVisualStyleBackColor = true;
            this.modEquipBtn.Click += new System.EventHandler(this.modEquipBtn_Click);
            // 
            // orderEquipBtn
            // 
            this.orderEquipBtn.Location = new System.Drawing.Point(269, 154);
            this.orderEquipBtn.Name = "orderEquipBtn";
            this.orderEquipBtn.Size = new System.Drawing.Size(261, 49);
            this.orderEquipBtn.TabIndex = 3;
            this.orderEquipBtn.Text = "Order Equipment";
            this.orderEquipBtn.UseVisualStyleBackColor = true;
            this.orderEquipBtn.Click += new System.EventHandler(this.orderEquipBtn_Click);
            // 
            // depotTxt
            // 
            this.depotTxt.AutoSize = true;
            this.depotTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depotTxt.Location = new System.Drawing.Point(37, 68);
            this.depotTxt.Name = "depotTxt";
            this.depotTxt.Size = new System.Drawing.Size(153, 55);
            this.depotTxt.TabIndex = 2;
            this.depotTxt.Text = "Depot";
            // 
            // repairBtn
            // 
            this.repairBtn.Location = new System.Drawing.Point(269, 296);
            this.repairBtn.Name = "repairBtn";
            this.repairBtn.Size = new System.Drawing.Size(261, 49);
            this.repairBtn.TabIndex = 4;
            this.repairBtn.Text = "Equipment Repair";
            this.repairBtn.UseVisualStyleBackColor = true;
            this.repairBtn.Click += new System.EventHandler(this.repairBtn_Click);
            // 
            // trckEquipBtn
            // 
            this.trckEquipBtn.Location = new System.Drawing.Point(269, 367);
            this.trckEquipBtn.Name = "trckEquipBtn";
            this.trckEquipBtn.Size = new System.Drawing.Size(261, 49);
            this.trckEquipBtn.TabIndex = 4;
            this.trckEquipBtn.Text = "Track Equipment";
            this.trckEquipBtn.UseVisualStyleBackColor = true;
            this.trckEquipBtn.Click += new System.EventHandler(this.trckEquipBtn_Click);
            // 
            // Depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trckEquipBtn);
            this.Controls.Add(this.repairBtn);
            this.Controls.Add(this.modEquipBtn);
            this.Controls.Add(this.orderEquipBtn);
            this.Controls.Add(this.depotTxt);
            this.Name = "Depot";
            this.Text = "Depot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modEquipBtn;
        private System.Windows.Forms.Button orderEquipBtn;
        private System.Windows.Forms.Label depotTxt;
        private System.Windows.Forms.Button repairBtn;
        private System.Windows.Forms.Button trckEquipBtn;
    }
}