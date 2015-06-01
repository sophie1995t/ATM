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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            CenterToScreen();
            InitializeComponent();
        }
        //when next button clicked go to new page.
        private void btnnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Validation().Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
