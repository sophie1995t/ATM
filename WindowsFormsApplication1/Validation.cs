using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM_Windows_Application;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Validation : Form
    {
        private int invalidAttempts;
        private const int MAX_INVALID_ATTEMPTS = 3;
        public Validation()
        {
            CenterToScreen();
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Closes Application
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                Authenticate();
            }
            else
            {
                //if invalid login user will be prompted that they will only have (2), (1) attempts left.
                invalidAttempts++;
                if (invalidAttempts < MAX_INVALID_ATTEMPTS)
                    MessageBox.Show(string.Format("Incorrect account number / PIN!! \n Please try again. You have {0} attempts to login", MAX_INVALID_ATTEMPTS - invalidAttempts), "Login fails...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //if invalid login user 3 times then account will be blocked.
                    //BlockCard();
                    MessageBox.Show(string.Format("You have tried incorrect login details {0} times.\n Your card is temporary blocked", MAX_INVALID_ATTEMPTS), "Card temporary blocked...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    new Welcome().Show();
                }
            }
        }

        private bool IsValid()
        {
            //if no text or numbers then message box to ask user to put it in
            if (string.IsNullOrWhiteSpace(txtAcc.Text))
            {
                MessageBox.Show("Please enter account number", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            //if text is longer than six characters the message box error will show
            else if (txtAcc.Text.Trim().Length != 6)
            {
                MessageBox.Show("Please enter valid account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if no text or numbers then message box to ask user to put it in
            else if (string.IsNullOrWhiteSpace(txtPin.Text))
            {
                MessageBox.Show("Please enter PIN", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            //if text is longer than four characters the message box error will show
            else if (txtPin.Text.Trim().Length != 4)
            {
                MessageBox.Show("Please enter valid PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Authenticate()
        {
            bool correctDetails = false;
            int accountNo;
            int.TryParse(txtAcc.Text, out accountNo);
            int pin;
            int With;
            int.TryParse(txtPin.Text, out pin);
            int numberOfAttempts = 0;
            int balance;
            
            //connection to database
            SqlConnection conn = new SqlConnection(
                "Data Source=STUDENT14\\SQLEXPRESS;Initial Catalog=BankATM;Integrated Security=SSPI");
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CustomerAccount WHERE AccountNumber = " + accountNo, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Convert.ToInt32(rdr["AccountNumber"]) == accountNo && Convert.ToInt32(rdr["PIN"]) == pin)
                    {
                        correctDetails = true;
                        balance = Convert.ToInt32(rdr["Balance"]);
                        MessageBox.Show("Your Username and Password is Correct");
                        new Option().Show();
                    }
                    else
                    {
                        correctDetails = false;
                        MessageBox.Show("Your Username or Password is Incorrect, Please input the correct details");
                        numberOfAttempts++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error {0}" + e);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }
            return correctDetails;
        }

        private void BlockCard()
        {

        }
    }
}
