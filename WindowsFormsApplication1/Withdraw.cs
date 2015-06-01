using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ATM_Windows_Application;

namespace WindowsFormsApplication1
{
    public partial class Withdraw : Form
    {
        public int With;
        //public Withdraw(int with);
            //this()
        //{
           // With = with;
        //}/
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Warning", "Are you sure you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Closes Application
                this.Close();
                new Welcome().Show();
            }
            else
            {
                new Validation().Show();
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Receipt", "Would you like a receipt?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Please collect your receipt");
                new ActionComplete().Show();
            }
            else
            {

            }
        }
           
        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
