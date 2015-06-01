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
    public partial class Option : Form
    {
        public int AccNumber;
        public int AccPin;
        public int AccBalance;
        public int AccWithdraw;
        public Option(int accountNo, int pin, int Balance, int With)
            : this()
        {
            AccNumber = accountNo;
            AccPin = pin;
            AccBalance = Balance;
            AccWithdraw = With;
        }
        public Option()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            this.Close();
            new Balance(AccBalance).Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Withdraw(AccWithdraw).Show();
        }

        private void Option_Load(object sender, EventArgs e)
        {

        }
    }
}
