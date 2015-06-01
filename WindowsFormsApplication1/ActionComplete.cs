using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ActionComplete : Form
    {
        public ActionComplete()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void ActionComplete_Load(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please Remove Card", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
            {
                //Closes Application
                new Welcome().Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Application
            Application.Exit();
        }
    }
}
