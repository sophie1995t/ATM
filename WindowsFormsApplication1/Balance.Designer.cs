namespace WindowsFormsApplication1
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.btnExit = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnwdpage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(32, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.lbltitle.TabIndex = 12;
            this.lbltitle.Text = "Welcome to the Quatrix ATM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Balance is:";
            // 
            // btnwdpage
            // 
            this.btnwdpage.BackColor = System.Drawing.SystemColors.Window;
            this.btnwdpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnwdpage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnwdpage.Location = new System.Drawing.Point(184, 275);
            this.btnwdpage.Name = "btnwdpage";
            this.btnwdpage.Size = new System.Drawing.Size(122, 52);
            this.btnwdpage.TabIndex = 14;
            this.btnwdpage.Text = "Withdraw";
            this.btnwdpage.UseVisualStyleBackColor = false;
            this.btnwdpage.Click += new System.EventHandler(this.btnwdpage_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Window;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(336, 275);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 52);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(249, 111);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(209, 26);
            this.lblBalance.TabIndex = 16;
            this.lblBalance.Text = "*Lists current balance*";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 355);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnwdpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnwdpage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBalance;
    }
}