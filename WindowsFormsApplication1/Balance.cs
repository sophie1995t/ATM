using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Balance : Form
    {
        public int Bal;
        public Balance(int balance): this()
        {
            Bal = balance;
        }
        public Balance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

            else
            {
                new Validation().Show();
            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActionComplete().Show();
        }

        private void btnwdpage_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewBalance()
        {
            
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load_1(object sender, EventArgs e)
        {
            lblBalance.Text = Convert.ToString(Bal);
        }
    }
}
