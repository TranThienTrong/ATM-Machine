using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* @author Tran Thien Trong - GCS290283
*
* @date - 10/October/2019 
*/

namespace ATM_SYSTEM
{
    public partial class MainForm : Form
    {
        // Variables Initialization 
        public static string safePass = null;
        bool login = false;
        public static double trans = 0;


        // Initialize 2 Account Objects
        Account acc = new Account("Admin", "1234", 1000.0, 0, 0, 0);
        Account acc1 = new Account("Trong", "2669", 500.0, 0, 0, 0);

        public static double amount = 0.0F;
        public static double tmp_amount1 = 0.0F;
        public static double tmp_amount2 = 0.0F;
        public static string accountName = "";

        private String SafePass
        {
            get { return safePass; }
            set { safePass = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// When the MainForm is loaded, Hide the User Group Box and Transfer Group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Invisible Group Box User
            groupBoxUser.Visible = false;

            // Hide all elements inside Group Box Transfer include itself
            groupBoxTransfer.Hide();
            
            // Hide 2 Accounts Avatars Until Identify
            pictureBoxTrans.Hide();
            pictureBoxTrans2.Hide();
            
            // Hide 2 Valid Marks
            pictureBoxInvalid.Hide(); 
            pictureBoxChecked.Hide();

            // Hide Transfer Section
            txtTransfer.Hide();
            btnTransfer.Hide();
        }

        // button click funtion from 0-9
        private void btn0_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {

            lblPin.Text += "O";
            safePass += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            lblPin.Text += "O";
            safePass += "9";
        }


        // Enter and Clear Buttons
        /// <summary>
        /// Check if the user input is matched with the account password or not.
        /// If matched, show the greeting on the screen with their name and avatar
        /// Set User Group Box to visible, set PIN label to emptyThe Receipt has been save at
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Admin Account
            if (safePass == "1234")
            {
                groupBoxUser.Visible = true;

                // Show Trong Avatar, Hide Admin Avatar             
                pictureBoxUser.Visible = false;
                pictureBoxAdmin.Visible = true;

                // Greeting with their name
                lblAccountName.Text = "Welcome, " + acc.name + " !";

                btnAccount.Show();
                lblPin.Text = ""; // Set Pin label to empty
            }
            // Trong Account
            else if (safePass == "2669")
            {
                groupBoxUser.Visible = true;

                // Show Trong Avatar, Hide Admin Avatar   
                pictureBoxAdmin.Visible = false;
                pictureBoxUser.Visible = true;

                // Greeting with their name
                lblAccountName.Text = "Welcome, " + acc1.name + " !";

                btnAccount.Show();
                lblPin.Text = ""; // Set Pin label to empty
            }
            // If PIN Number is not match with account data
            else
            {
                lblPin.Text = "Invalid PIN Numbers";
            }
        }

        /// <summary>
        /// Hide User and Transfer Group Boxs, include their elements
        /// Set empty for all text box in MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            trans = 0;
            login = false;
            if (safePass == "1234")
            {
                tmp_amount1 = AccountForm.amount;
                acc.amount = tmp_amount1;
            }
            else if (safePass == "2669")
            {
                tmp_amount2 = AccountForm.amount;
                acc1.amount = tmp_amount2;
            }

            //Reset PIN number
            lblPin.Text = "";
            safePass = null;

            //Reset Group Box User
            groupBoxUser.Hide();
            lblAccountName.Text = "";

            // Reset Group Box Transfer
            groupBoxTransfer.Hide();
            
            // Hide all avatar
            pictureBoxTrans.Hide();
            pictureBoxTrans2.Hide();

            // Hide all valid marks
            pictureBoxInvalid.Hide();
            pictureBoxChecked.Hide();

            // Set empty for transfer section
            textBoxTransferReceiver.Text = "";
            txtTransfer.Text = "";
            txtTransfer.Hide();
            btnTransfer.Hide();
        }


        // Account Button and Exchange button in User Group Box
        /// <summary>
        /// Open AccountForm
        /// Assign all value of variables from Account to variables in AccountForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccount_Click(object sender, EventArgs e)
        {    
            // Case Admin account is using
            if (safePass == "1234")
            {
                accountName = acc.name;
                if (login == false)
                {
                    amount = acc.amount;
                    
                }
                else if (login == true)
                {
                    amount = AccountForm.amount-trans;
                    trans = 0;
                }
                login = true;
            }
            // Case Trong account is using
            if (safePass == "2669")
            {
                accountName = acc1.name;
                if (login == false)
                {
                    amount = acc1.amount;
                }
                if (login == true)
                {
                    amount = AccountForm.amount - trans;
                    trans = 0;
                }
                login = true;
            }

            // Open Account Form Dialog
            using (AccountForm accountForm = new AccountForm())
            {
                accountForm.ShowDialog();
            }
        }

        
        /// <summary>
        /// When btnExchange is clicked, the transfer group box turn from hide to show.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExchange_Click(object sender, EventArgs e)
        {
            groupBoxTransfer.Show();
            textBoxTransferReceiver.Show();
            btnFindReceiver.Show();
        }

        // Find Receiver and Transfer Button in Transfer Group Box
        /// <summary>
        /// Find the account name
        /// If account name is matched, show their avatar and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindReceiver_Click(object sender, EventArgs e)
        {
            // Case Admin account is using
            if (safePass == "1234")
            {
                // Check if you type correct another account name
                if (textBoxTransferReceiver.Text == acc1.name)
                {
                    // The find receiver section turn from Show -> hide
                    textBoxTransferReceiver.Hide();
                    btnFindReceiver.Hide();

                    // The transfer and receiver avatar section turn from Hide -> Show 
                    pictureBoxTrans2.Show();
                    txtTransfer.Show();
                    btnTransfer.Show();
                }
                else
                {
                    textBoxTransferReceiver.Text = "Can not find accounts name";
                    MessageBox.Show("Can not find accounts name");
                    textBoxTransferReceiver.Text = "";
                }
            }
            // Case Trong account is using
            else if (safePass == "2669")
            {
                // Check if you type correct another account name
                if (textBoxTransferReceiver.Text == acc.name)
                {
                    // The find receiver section turn from Show -> hide
                    textBoxTransferReceiver.Hide();
                    btnFindReceiver.Hide();

                    // The transfer and receiver avatar section turn from Hide -> Show 
                    pictureBoxTrans.Show();
                    txtTransfer.Show();
                    btnTransfer.Show();
                }
                else
                {
                    textBoxTransferReceiver.Text = "Can not find accounts name";
                    MessageBox.Show("Can not find accounts name");
                    textBoxTransferReceiver.Text = "";
                }
            }
        }
       
        /// <summary>
        /// Transfer amount money from Account you are using to another account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var transferAmount = Convert.ToDouble(txtTransfer.Text);
           
            
            // Case Admin account is using
            if (safePass == "1234")
            {
                if (transferAmount <= acc.amount)
                {
                    // Receiver account increase and the current account is decreased in the same amount 
                    acc1.amount += transferAmount;
                    acc.amount -= transferAmount;

                    // The valid mark show 
                    pictureBoxInvalid.Hide();
                    pictureBoxChecked.Show();
                    trans = transferAmount;

                }
                else
                {
                    // The Invalid Mark show up
                    pictureBoxChecked.Hide();
                    pictureBoxInvalid.Show();
                }
            }
            // Case Trong account is using
            else if (safePass == "2669")
            {
                if (transferAmount <= acc1.amount)
                {
                    // Receiver account increase and the current account is decreased in the same amount 
                    acc.amount += transferAmount;
                    acc1.amount -= transferAmount;

                  
                    // The Valid Mark show up
                    pictureBoxInvalid.Hide();
                    pictureBoxChecked.Show();

                    trans = transferAmount;
                }
                else
                {
                    // The Invalid Mark show up
                    pictureBoxChecked.Hide();
                    pictureBoxInvalid.Show();
                }
            }
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } // End MainForm
} // End namespace
