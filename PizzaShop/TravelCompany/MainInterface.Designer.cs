namespace TravelCompany
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.newOrderBtnMain = new System.Windows.Forms.Button();
            this.ordersBtnMain = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newOrderBtnMain
            // 
            this.newOrderBtnMain.BackColor = System.Drawing.Color.Maroon;
            this.newOrderBtnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrderBtnMain.FlatAppearance.BorderSize = 3;
            this.newOrderBtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderBtnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderBtnMain.ForeColor = System.Drawing.Color.SandyBrown;
            this.newOrderBtnMain.Location = new System.Drawing.Point(387, 156);
            this.newOrderBtnMain.Name = "newOrderBtnMain";
            this.newOrderBtnMain.Size = new System.Drawing.Size(176, 112);
            this.newOrderBtnMain.TabIndex = 0;
            this.newOrderBtnMain.Text = "НОВА ПОРЪЧКА";
            this.newOrderBtnMain.UseVisualStyleBackColor = false;
            this.newOrderBtnMain.Click += new System.EventHandler(this.transportsBtnMain_Click);
            // 
            // ordersBtnMain
            // 
            this.ordersBtnMain.BackColor = System.Drawing.Color.Maroon;
            this.ordersBtnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtnMain.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.ordersBtnMain.FlatAppearance.BorderSize = 3;
            this.ordersBtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtnMain.ForeColor = System.Drawing.Color.SandyBrown;
            this.ordersBtnMain.Location = new System.Drawing.Point(387, 299);
            this.ordersBtnMain.Name = "ordersBtnMain";
            this.ordersBtnMain.Size = new System.Drawing.Size(176, 112);
            this.ordersBtnMain.TabIndex = 1;
            this.ordersBtnMain.Text = "ПОРЪЧКИ";
            this.ordersBtnMain.UseVisualStyleBackColor = false;
            this.ordersBtnMain.Click += new System.EventHandler(this.tripsBtnMain_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Maroon;
            this.mainLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLabel.Font = new System.Drawing.Font("Andalus", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.mainLabel.Location = new System.Drawing.Point(284, 38);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(390, 61);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Пицария \"Рома\"";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Maroon;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 3;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.exitBtn.Location = new System.Drawing.Point(387, 455);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(176, 112);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 631);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.ordersBtnMain);
            this.Controls.Add(this.newOrderBtnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainInterface";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newOrderBtnMain;
        private System.Windows.Forms.Button ordersBtnMain;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button exitBtn;
    }
}