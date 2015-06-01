namespace WindowsFormsApplication1
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbalance = new System.Windows.Forms.Button();
            this.btnWithNR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.White;
            this.lbltitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltitle.Location = new System.Drawing.Point(88, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(422, 48);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Welcome to the Quatrix ATM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select an option:";
            // 
            // btnbalance
            // 
            this.btnbalance.BackColor = System.Drawing.SystemColors.Window;
            this.btnbalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbalance.Location = new System.Drawing.Point(32, 118);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(212, 91);
            this.btnbalance.TabIndex = 2;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = false;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnWithNR
            // 
            this.btnWithNR.BackColor = System.Drawing.SystemColors.Window;
            this.btnWithNR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWithNR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWithNR.Location = new System.Drawing.Point(267, 118);
            this.btnWithNR.Name = "btnWithNR";
            this.btnWithNR.Size = new System.Drawing.Size(212, 91);
            this.btnWithNR.TabIndex = 4;
            this.btnWithNR.Text = "Withdraw\r\n";
            this.btnWithNR.UseVisualStyleBackColor = false;
            this.btnWithNR.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(32, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 52);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 355);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWithNR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btnWithNR;
        private System.Windows.Forms.Button btnExit;
    }
}